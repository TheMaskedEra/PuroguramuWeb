using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.Domains;
using Puroguramu.Domains.Models;

namespace Puroguramu.App.Areas.User.Pages.Lessons;

// [Authorize(Roles = "Student, Teacher")]
public class LessonPageModel : PageModel
{
    public void OnGet()
    {
    }

    public Lesson Lesson => new("Lesson 1")
    {
        Description = "Description 1", FinishedPercentage = 100,
    };

    public List<Exercise> Exercises => new()
    {
        new Exercise
        {
            Title = "Exercice 1",
            Instructions = "Instructions 1",
            Difficulty = ExerciseDifficulty.Easy,
            Solution = "Solution 1",
            Status = ExerciseStatus.Passed,
        },
        new Exercise
        {
            Title = "Exercice 2",
            Instructions = "Instructions 2",
            Difficulty = ExerciseDifficulty.Medium,
            Solution = "Solution 2",
            Status = ExerciseStatus.Started,
        },
        new Exercise
        {
            Title = "Exercice 3",
            Instructions = "Instructions 3",
            Difficulty = ExerciseDifficulty.Medium,
            Solution = "Solution 3",
            Status = ExerciseStatus.NotStarted,
        },
        new Exercise
        {
            Title = "Exercice 4",
            Instructions = "Instructions 4",
            Difficulty = ExerciseDifficulty.Medium,
            Solution = "Solution 4",
            Status = ExerciseStatus.NotStarted,
        },
        new Exercise
        {
            Title = "Exercice 5",
            Instructions = "Instructions 5",
            Difficulty = ExerciseDifficulty.Hard,
            Solution = "Solution 5",
            Status = ExerciseStatus.NotStarted,
        },
    };
}
