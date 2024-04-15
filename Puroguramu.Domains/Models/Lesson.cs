using System.Collections;

namespace Puroguramu.Domains.Models;

public class Lesson
{
    public Lesson(string title)
    {
        Title = title;
    }

    public string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public bool IsVisible { get; set; } = false;

    public int FinishedPercentage { get; set; }

    //TODO public ICollection<Exercise> Exercises { get; set; } = new SortedList();

    //public void AddExercise(Exercise exercise) => Exercises.Add(exercise);
}
