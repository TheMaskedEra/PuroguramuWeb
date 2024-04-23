using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.App.Pages.ViewModels;
using Puroguramu.Domains.Models;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.App.Areas.Teacher.Pages.Lessons;

public class DashboardModel : PageModel
{
    private readonly UserManager<Users> _userManager;

    public DashboardModel(UserManager<Users> userManager)
    {
        _userManager = userManager;
    }

    public List<LessonViewModel> Lessons => new()
    {
        new LessonViewModel(new Lesson("Lesson 1") { Description = "Description 1", FinishedPercentage = 100 }),
        new LessonViewModel(new Lesson("Lesson 2") { Description = "Description 2", FinishedPercentage = 75 }),
        new LessonViewModel(new Lesson("Lesson 3") { Description = "Description 3", FinishedPercentage = 50 }),
        new LessonViewModel(new Lesson("Lesson 4") { Description = "Description 4", FinishedPercentage = 25 }),
        new LessonViewModel(new Lesson("Lesson 5") { Description = "Description 5", FinishedPercentage = 0 }),
        new LessonViewModel(new Lesson("Lesson 6") { Description = "Description 6", FinishedPercentage = 0 }),
        new LessonViewModel(new Lesson("Lesson 7") { Description = "Description 7", FinishedPercentage = 0 }),
    };

    public UserDashboardViewModel UserDashboardView { get; set; } = new ();

    public async Task OnGetAsync()
    {
        if (User.Identity is { IsAuthenticated: true })
        {
            var user = await _userManager.GetUserAsync(User);
            UserDashboardView.Name = user.LastName;
            UserDashboardView.FirstName = user.FirstName;
        }
    }
}
