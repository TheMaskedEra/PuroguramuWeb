using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Puroguramu.Infrastructures.Data.Configurations;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data;

public class PuroguramuDbContext : IdentityDbContext<Users>
{
    public PuroguramuDbContext(DbContextOptions options)
        :base(options)
    {
    }

    public DbSet<Users> Users { get; set; }

    public DbSet<Languages> Languages { get; set; }

    public DbSet<Courses> Courses { get; set; }

    public DbSet<Lessons> Lessons { get; set; }

    public DbSet<Exercises> Exercises { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new LanguagesConfiguration());
        builder.ApplyConfiguration(new CoursesConfiguration());
        builder.ApplyConfiguration(new LessonsConfiguration());
    }
}
