using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Puroguramu.Infrastructures.Data.Configurations;

namespace Puroguramu.Infrastructures.Data;

public class PuroguramuDbContext : IdentityDbContext<Users>
{

    public PuroguramuDbContext(DbContextOptions options)
        :base(options)
    {
    }

    public DbSet<Lessons> Lessons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Languages>()
            .HasIndex(l => l.Name)
            .IsUnique();

        modelBuilder.Entity<Lessons>()
            .HasIndex(l => l.Title)
            .IsUnique();

        modelBuilder.Entity<Courses>()
            .HasIndex(c => new { c.Title, c.Language })
            .IsUnique();

        modelBuilder.ApplyConfiguration(new LessonOrdersConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
