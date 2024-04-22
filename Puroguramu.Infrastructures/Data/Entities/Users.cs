using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Users : IdentityUser
{
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [StringLength(15)]
    public string RegistrationNumber { get; set; } = string.Empty;

    public string GroupId { get; set; } = string.Empty;

    public Groups Group { get; set; } = null!;

    public byte[]? ProfilePicturePath { get; set; }
}
