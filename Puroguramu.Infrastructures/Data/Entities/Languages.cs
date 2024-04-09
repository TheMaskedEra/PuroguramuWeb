using System.ComponentModel.DataAnnotations;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Languages
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    public ICollection<Courses> Courses { get; } = new List<Courses>();
}
