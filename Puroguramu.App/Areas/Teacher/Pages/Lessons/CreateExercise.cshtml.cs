using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.App.Areas.Teacher.Models;

namespace Puroguramu.App.Areas.Teacher.Pages.Lessons;

// [Authorize(Roles = "Teacher")]
public class CreateExerciseModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new ();

    public CreateFormModel FormModel { get; set; }

    public CreateExerciseModel()
    {
        FormModel = new CreateFormModel {Type = "exercice", Title = "l'exercice", InputValue = Input.Title};
    }

    public class InputModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
    }

    public void OnGet() => InitializeFormModel();

    public async Task OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            InitializeFormModel();
        }
    }

    private void InitializeFormModel() => FormModel = new CreateFormModel { Type = "exercice", Title = "l'exercice", InputValue = Input.Title };
}
