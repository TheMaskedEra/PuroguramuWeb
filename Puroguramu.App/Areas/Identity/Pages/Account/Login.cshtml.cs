#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.Domains.Repositories;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.App.Areas.Identity.Pages.Account;

public class LoginModel : PageModel
{
    private readonly SignInManager<Users> _signInManager;
    private readonly ILogger<LoginModel> _logger;

    private readonly IUserRepository _userRepository;

    public LoginModel(SignInManager<Users> signInManager, ILogger<LoginModel> logger, IUserRepository userRepository)
    {
        _signInManager = signInManager;
        _logger = logger;
        _userRepository = userRepository;
    }

    [BindProperty]
    public InputModel Input { get; set; }

    public string ReturnUrl { get; set; }

    [TempData]
    public string ErrorMessage { get; set; }

    public class InputModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public async Task OnGetAsync(string returnUrl = null)
    {
        if (!string.IsNullOrEmpty(ErrorMessage))
        {
            ModelState.AddModelError(string.Empty, ErrorMessage);
        }

        returnUrl ??= Url.Content("~/");

        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        ReturnUrl = returnUrl;
    }

    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        if (!ModelState.IsValid)
        {
            return Page();
        }

        string username;
        if (Regex.IsMatch(Input.UserName, @"^[a-zA-Z]\d{6}$"))
        {
            username = await _userRepository.FindEmailFromRegistrationNumber(Input.UserName.ToUpper()) ?? string.Empty;
        }
        else
        {
            username = Input.UserName;
        }

        // This doesn't count login failures towards account lockout
        // To enable password failures to trigger account lockout, set lockoutOnFailure: true
        var result = await _signInManager.PasswordSignInAsync(username, Input.Password, Input.RememberMe, lockoutOnFailure: false);

        if (result.Succeeded)
        {
            _logger.LogInformation("User logged in.");
            return LocalRedirect(returnUrl);
        }

        if (result.IsLockedOut)
        {
            _logger.LogWarning("User account locked out.");
            return RedirectToPage("./Lockout");
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        return Page();
    }
}
