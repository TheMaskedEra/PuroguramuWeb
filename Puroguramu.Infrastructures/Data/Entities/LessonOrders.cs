namespace Puroguramu.Infrastructures.Data.Entities;

public class LessonOrders
{
    public string LessonId { get; set; }

    public Lessons Lesson { get; set; } = null!;

    public string? LessonBeforeId { get; set; }

    public Lessons? LessonBefore { get; set; } = null;

    public string? LessonAfterId { get; set; }

    public Lessons? LessonAfter { get; set; } = null;
}
