using System.ComponentModel.DataAnnotations;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Groups
{
    public int Id { get; set; }

    [StringLength(10)]
    public string Name { get; init; } = string.Empty;
}
