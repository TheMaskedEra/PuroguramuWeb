using System.ComponentModel.DataAnnotations;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Courses
{
    public string Id { get; set; } = string.Empty;

    [StringLength(150)]
    public string Title { get; set; } = null!;

    public string LanguageId { get; set; } = string.Empty;

    public Languages Language { get; set; } = null!;

    public ICollection<Lessons> Lessons { get; set; } = new List<Lessons>();
}
