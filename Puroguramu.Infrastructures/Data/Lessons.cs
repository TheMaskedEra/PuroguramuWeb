using System.ComponentModel.DataAnnotations;

namespace Puroguramu.Infrastructures.Data;

public class Lessons
{
    public int Id { get; set; }

    public Courses Course { get; set; } = null!;

    [StringLength(150)]
    public string Title { get; set; } = null!;

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    public bool IsVisible { get; set; } = false;

    public LessonOrders Order { get; set; } = null!;

    public ICollection<Exercises> Exercises { get; set; } = new List<Exercises>();
}
