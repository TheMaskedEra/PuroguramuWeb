using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.App.Pages.Models;
using Puroguramu.Domains.Models;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.App.Areas.User.Pages.Lessons;

[Authorize(Roles = "Student")]
public class DashboardModel : PageModel
{
    private readonly ILogger<DashboardModel> _logger;
    private readonly UserManager<Users> _userManager;

    public DashboardModel(ILogger<DashboardModel> logger, UserManager<Users> userManager)
    {
        _logger = logger;
        _userManager = userManager;
    }

    public async Task OnGetAsync()
    {
        if (User.Identity is { IsAuthenticated: true })
        {
            var user = await _userManager.GetUserAsync(User);
            UserDashboard.Name = user.LastName;
            UserDashboard.FirstName = user.FirstName;
        }
    }

    public UserDashboardModel UserDashboard { get; set; } = new ();

    public List<Lesson> Lessons => new()
    {
        new Lesson("Lesson 1") {  Description = "Description 1", FinishedPercentage = 100 },
        new Lesson("Lesson 2") { Description = "Description 2", FinishedPercentage = 75 },
        new Lesson("Lesson 3") { Description = "Description 3", FinishedPercentage = 50 },
        new Lesson("Lesson 4") { Description = "Description 4", FinishedPercentage = 25 },
        new Lesson("Lesson 5") { Description = "Description 5", FinishedPercentage = 0 },
        new Lesson("Lesson 6") { Description = "Description 6", FinishedPercentage = 0 },
        new Lesson("Lesson 7") { Description = "Description 7", FinishedPercentage = 0 },
    };

    public int GetFinishedPercentage(Lesson lesson) => lesson.FinishedPercentage == 0 ? 1 : lesson.FinishedPercentage;
}
