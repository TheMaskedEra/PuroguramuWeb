namespace Puroguramu.Infrastructures.Data.Entities;

public class LessonOrders
{
    public int LessonId { get; set; }

    public Lessons Lesson { get; set; } = null!;

    public int? LessonBeforeId { get; set; }

    public Lessons? LessonBefore { get; set; } = null;

    public int? LessonAfterId { get; set; }

    public Lessons? LessonAfter { get; set; } = null;
}
