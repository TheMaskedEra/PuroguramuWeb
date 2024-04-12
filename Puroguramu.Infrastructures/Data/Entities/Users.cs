using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Users : IdentityUser
{
    [StringLength(15)]
    public string RegistrationNumber { get; set; } = string.Empty;

    [StringLength(3)]
    public string Group { get; set; } = string.Empty;
}
