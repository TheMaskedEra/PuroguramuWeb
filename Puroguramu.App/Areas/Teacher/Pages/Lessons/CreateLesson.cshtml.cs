using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Puroguramu.App.Areas.Teacher.Pages.Lessons;

// [Authorize(Roles = "Teacher")]
public class CreateLessonModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
    }

    public void OnGet()
    {
    }

    public async Task OnPostAsync()
    {
    }
}
