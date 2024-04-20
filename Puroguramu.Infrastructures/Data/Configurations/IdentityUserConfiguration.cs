using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class IdentityUserConfiguration : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.HasOne(u => u.Group)
            .WithMany()
            .HasForeignKey(u => u.GroupId);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Users> builder)
    {
        var ph = new PasswordHasher<Users>();
        var alexis = new Users()
        {
            FirstName = "Alexis",
            LastName = "LastName",
            Email = "a.vandenbroeck@student.helmo.be",
            RegistrationNumber = "E200971",
            GroupId = GroupsConfiguration.ThirdGroupId.ToString(),
        };
        ph.HashPassword(alexis, "123456");

        builder.HasData(alexis);
    }
}
