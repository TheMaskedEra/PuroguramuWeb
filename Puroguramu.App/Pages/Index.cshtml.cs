using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Puroguramu.App.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
    }

    public int ExerciseNumber => 1000;

    public int LessonNumber => 50;

    public int StudentNumber => 100;
}
