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

        builder.HasAlternateKey(u => u.RegistrationNumber);
        builder.HasAlternateKey(u => u.Email);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Users> builder)
    {
    }
}
