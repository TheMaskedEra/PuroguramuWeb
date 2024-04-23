using System.ComponentModel.DataAnnotations;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Groups
{
    public string Id { get; set; } = string.Empty;

    [StringLength(10)]
    public string Name { get; init; } = string.Empty;

    public List<Users> Students { get; set; } = new ();
}
