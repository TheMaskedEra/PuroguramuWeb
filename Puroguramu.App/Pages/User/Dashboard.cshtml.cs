using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.Domains.Models;

namespace Puroguramu.App.Pages.User;

[Authorize(Roles = "Student, Teacher")]
public class DashboardModel : PageModel
{
    public void OnGet()
    {
    }

    public AppUser AppUser => new("123456", "Doe", "John", "john.doe@gmail.com", "2i3");

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
