using Microsoft.AspNetCore.Mvc.RazorPages;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.App.Pages;

public class IndexModel : PageModel
{
    private readonly ILessonRepository _lessonRepo;

    private readonly IUserRepository _userRepo;

    private readonly IExerciseRepository _exerciseRepo;

    public IndexModel(ILessonRepository lessonRepo, IUserRepository userRepo, IExerciseRepository exerciseRepo)
    {
        _lessonRepo = lessonRepo;
        _userRepo = userRepo;
        _exerciseRepo = exerciseRepo;
    }

    public async Task OnGetAsync()
    {
        ExerciseNumber = await _exerciseRepo.GetTotalNumberAsync();
        LessonNumber = await _lessonRepo.GetTotalNumberAsync();
        StudentNumber = await _userRepo.GetTotalStudentNumberAsync();
    }

    public int ExerciseNumber { get; private set; }

    public int LessonNumber { get; private set; }

    public int StudentNumber
    {
        get;
        private set;
    }
}
