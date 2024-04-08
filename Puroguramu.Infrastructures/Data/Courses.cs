using System.ComponentModel.DataAnnotations;

namespace Puroguramu.Infrastructures.Data;

public class Courses
{
    public int Id { get; set; }

    [StringLength(150)]
    public string Title { get; set; } = null!;

    public Languages Language { get; set; } = null!;

    public IList<Lessons> Lessons { get; set; } = new List<Lessons>();
}
