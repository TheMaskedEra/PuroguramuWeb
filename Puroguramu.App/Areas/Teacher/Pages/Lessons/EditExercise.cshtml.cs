using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Puroguramu.App.Areas.Teacher.Pages.Lessons;

public class EditExercise : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public void OnGet()
    {
        Input = new InputModel();
    }

    public async Task OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            Input = new InputModel();
            return;
        }
    }

    public class InputModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Text)]
        public string Model { get; set; } = "// Tapez votre modèle ici";

        [Required]
        [DataType(DataType.Text)]
        public string Answer { get; set; } = "// Tapez votre solution ici";
    }
}
