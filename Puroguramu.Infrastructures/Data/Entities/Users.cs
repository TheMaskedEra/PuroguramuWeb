using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Users : IdentityUser
{
    [StringLength(15)]
    public string RegistrationNumber { get; set; } = string.Empty;

    public string GroupId { get; set; } = string.Empty;

    public Groups Group { get; set; } = null!;
}
