using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        var adminRole = new IdentityRole()
        {

        };

        var teacherRole = new IdentityRole()
        {

        };
    }
}
