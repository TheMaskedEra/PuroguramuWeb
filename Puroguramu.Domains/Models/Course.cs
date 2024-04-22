namespace Puroguramu.Domains.Models;

public class Course
{
    public Course(string title, string language, ICollection<Lesson> lessons)
    {
        Title = title;
        Language = language;
        Lessons = lessons;
    }

    public string Title { get; set; }

    public string Language { get; }

    public ICollection<Lesson> Lessons { get; set; }
}
