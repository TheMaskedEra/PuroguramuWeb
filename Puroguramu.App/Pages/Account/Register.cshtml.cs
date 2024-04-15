using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.App.Pages.Account;

public class RegisterModel : PageModel
{
    private readonly IUsersRepository _repository;
    private readonly IPasswordHasher<AppUser> _passwordHasher;

    public RegisterModel(IUsersRepository repository, IPasswordHasher<AppUser> passwordHasher)
    {
        _repository = repository;
        _passwordHasher = passwordHasher;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost(string name, string firstname, string email, string password, string passwordConf, string group, string matricule)
    {
        if (password != passwordConf)
        {
            return Page();
        }

        var user = new AppUser(matricule, name, firstname, email, group);
        password = _passwordHasher.HashPassword(user, password);

        await _repository.InsertAsync(user, password);
        return RedirectToPage("/User/Dashboard");
    }
}
