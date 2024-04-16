using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public static readonly Guid AdminId = Guid.NewGuid();

    public static readonly Guid TeacherId = Guid.NewGuid();

    public static readonly Guid StudentId = Guid.NewGuid();

    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        var adminRole = new IdentityRole()
        {
            Id = AdminId.ToString(),
            ConcurrencyStamp = AdminId.ToString(),
            Name = "Admin",
            NormalizedName = "ADMIN",
        };

        var teacherRole = new IdentityRole()
        {
            Id = TeacherId.ToString(),
            ConcurrencyStamp = TeacherId.ToString(),
            Name = "Teacher",
            NormalizedName = "TEACHER",
        };

        var studentRole = new IdentityRole()
        {
            Id = StudentId.ToString(),
            ConcurrencyStamp = StudentId.ToString(),
            Name = "Student",
            NormalizedName = "STUDENT",
        };

        builder.HasData(adminRole, teacherRole, studentRole);
    }
}
