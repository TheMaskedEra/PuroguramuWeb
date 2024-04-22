using Puroguramu.Domains.Models;

namespace Puroguramu.App.Pages.ViewModels;

public class LessonViewModel
{
    private readonly Lesson _lesson;

    public LessonViewModel(Lesson lesson)
    {
        _lesson = lesson;
    }

    public string Title => _lesson.Title;

    public int GetFinishedPercentage()
        => _lesson.FinishedPercentage == 0 ? 1 : _lesson.FinishedPercentage;
}
