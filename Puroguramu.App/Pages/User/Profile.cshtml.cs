using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.Domains.Entities;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.App.Pages.User;

[Authorize(Roles = "Student, Teacher")]
public class ProfileModel : PageModel
{
    private readonly IUsersRepository _repository;

    public ProfileModel(IUsersRepository repository)
    {
        _repository = repository;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost(string name, string firstname, string email, string password, string passwordConf, string group)
    {
        if (password != passwordConf)
        {
            return Page();
        }

        var user = new AppUser
        {
            Name = name,
            Firstname = firstname,
            Email = email,
            Password = password,
            Group = group,
        };
        await _repository.UpdateAsync(user);
        return Page();
    }
}
