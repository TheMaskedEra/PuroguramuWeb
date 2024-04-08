namespace Puroguramu.Infrastructures.Data;

public class LessonOrders
{
    public int LessonId { get; set; }

    public Lessons Lesson { get; set; } = null!;

    public int? LessonBeforeId { get; set; }

    public Lessons? LessonBefore { get; set; }

    public int? LessonAfterId { get; set; }

    public Lessons? LessonAfter { get; set; }
}
