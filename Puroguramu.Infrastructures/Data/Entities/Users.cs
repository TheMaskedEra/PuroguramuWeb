using Microsoft.AspNetCore.Identity;

namespace Puroguramu.Infrastructures.Data.Entities;

public class Users : IdentityUser
{
    public int Id { get; set; }
}
