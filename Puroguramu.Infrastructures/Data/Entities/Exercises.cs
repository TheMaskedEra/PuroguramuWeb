using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Exercises
{
    public string Id { get; set; } = string.Empty;

    [StringLength(150)]
    public string Title { get; set; } = string.Empty;

    [StringLength(500)]
    public string Instructions { get; set; } = string.Empty;

    public int DifficultyLevel { get; set; } = -1;

    [StringLength(500)]
    public string Skeleton { get; set; } = string.Empty;

    public string LessonId { get; set; } = string.Empty;

    public Lessons Lesson { get; set; } = null!;

    public ExerciseOrders Order { get; set; } = null!;
}
