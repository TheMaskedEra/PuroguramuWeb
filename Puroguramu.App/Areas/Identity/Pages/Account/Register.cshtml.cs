#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Puroguramu.Domains.Repositories;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.App.Areas.Identity.Pages.Account;

public class RegisterModel : PageModel
{
    private readonly SignInManager<Users> _signInManager;
    private readonly UserManager<Users> _userManager;
    private readonly IUserStore<Users> _userStore;
    private readonly IUserEmailStore<Users> _emailStore;
    private readonly ILogger<RegisterModel> _logger;

    private readonly IGroupRepository _groupRepository;
    private readonly IUserRepository _userRepository;

    public RegisterModel(
        UserManager<Users> userManager,
        IUserStore<Users> userStore,
        SignInManager<Users> signInManager,
        ILogger<RegisterModel> logger,
        IGroupRepository groupRepository,
        IUserRepository userRepository)
    {
        _userManager = userManager;
        _userStore = userStore;
        _emailStore = GetEmailStore();
        _signInManager = signInManager;
        _logger = logger;
        _groupRepository = groupRepository;
        _userRepository = userRepository;
    }

    public List<string> Groups { get; set; }

    [BindProperty]
    public InputModel Input { get; set; }

    public string ReturnUrl { get; set; }

    public IList<AuthenticationScheme> ExternalLogins { get; set; }

    public class InputModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100,
            ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Veuillez choisir un groupe")]
        public string Group { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(7,
            ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 7)]
        public string RegistrationNumber { get; set; }
    }

    public async Task OnGetAsync(string returnUrl = null)
    {
        ReturnUrl = returnUrl;
        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        Groups = await _groupRepository.GetAllGroupNamesAsync();
    }

    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");
        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        Groups = await _groupRepository.GetAllGroupNamesAsync();

        if (!ModelState.IsValid)
        {
            return Page();
        }

        var user = CreateUser();
        var registrationNumber = Input.RegistrationNumber.ToUpper();

        var regValid = await IsRegistrationNumberValidAsync(registrationNumber);
        var emailValid = await IsEmailValid(Input.Email);

        if (!regValid || !emailValid)
        {
            return Page();
        }

        user.RegistrationNumber = registrationNumber;
        var groupId = await _groupRepository.GetGroupIdFromName(Input.Group);

        if (groupId == null)
        {
            throw new NotImplementedException();
        }

        user.GroupId = groupId;
        user.LastName = Input.Name;
        user.FirstName = Input.FirstName;

        await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
        await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
        var result = await _userManager.CreateAsync(user, Input.Password);

        if (result.Succeeded) //TODO Faire une vérification de role ? Faire un repo pour gérer la transaction d'ajout de role ?
        {
            _logger.LogInformation("User created a new account with password.");

            await _userManager.AddToRoleAsync(user, "Student");

            var userId = await _userManager.GetUserIdAsync(user);

            await _signInManager.SignInAsync(user, isPersistent: false);
            return LocalRedirect(returnUrl);
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        // If we got this far, something failed, redisplay form
        return Page();
    }

    private async Task<bool> IsRegistrationNumberValidAsync(string registrationNumber)
    {
        if (!Regex.IsMatch(registrationNumber, @"^[a-zA-Z]\d{6}$"))
        {
            ModelState.AddModelError("Input.RegistrationNumber", "Le matricule ne contient pas le bon format.");
            return false;
        }

        if (!await _userRepository.RegistrationNumberExistsAsync(registrationNumber))
        {
            return true;
        }

        ModelState.AddModelError("Input.RegistrationNumber", "Un compte avec ce matricule a déjà été engregisté.");
        return false;
    }

    private async Task<bool> IsEmailValid(string email)
    {
        if (!Regex.IsMatch(email, @".*@student\.helmo\.be$"))
        {
            ModelState.AddModelError("Input.Email", "L'adresse email ne correspond pas à une adresse helmo.");
            return false;
        }

        if (!await _userRepository.EmailExistsAsync(email))
        {
            return true;
        }

        ModelState.AddModelError("Input.Email", "Un compte avec cet email a déjà été enregistré.");
        return false;
    }

    private Users CreateUser()
    {
        try
        {
            return Activator.CreateInstance<Users>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(Users)}'. " +
                                                $"Ensure that '{nameof(Users)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
        }
    }

    private IUserEmailStore<Users> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail)
        {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }

        return (IUserEmailStore<Users>)_userStore;
    }
}
