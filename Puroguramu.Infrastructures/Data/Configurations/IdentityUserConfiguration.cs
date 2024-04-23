using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class IdentityUserConfiguration : IEntityTypeConfiguration<Users>
{
    public static readonly Guid VanAssId = Guid.NewGuid();

    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.HasOne(u => u.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(u => u.GroupId)
            .IsRequired(false);

        builder.HasAlternateKey(u => u.RegistrationNumber);
        builder.HasAlternateKey(u => u.Email);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Users> builder)
    {
        var ph = new PasswordHasher<Users>();
        string hashPassword;

        var vanass = new Users()
        {
            Id = VanAssId.ToString(),
            LastName = "Van Ass",
            FirstName = "Grégory",
            RegistrationNumber = "P210020",
            Email = "g.vanass@helmo.be",
            NormalizedEmail = "G.VANASS@HELMO.BE",
            UserName = "g.vanass@helmo.be",
            NormalizedUserName = "G.VANASS@HELMO.BE",
        };
        hashPassword =  ph.HashPassword(vanass, "Teacher123!");
        vanass.PasswordHash = hashPassword;

        builder.HasData(vanass);
    }
}
