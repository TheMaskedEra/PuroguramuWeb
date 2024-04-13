using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Exercises
{
    public int Id { get; set; }

    [StringLength(150)]
    public string Title { get; set; } = string.Empty;

    [StringLength(500)]
    public string Instructions { get; set; } = string.Empty;

    public int DifficultyLevel { get; set; } = -1;

    [StringLength(500)]
    public string Skeleton { get; set; } = string.Empty;

    public int LessonId { get; set; }

    public Lessons Lesson { get; set; } = null!;

    public ExerciseOrders Order { get; set; } = null!;
}
