using Microsoft.EntityFrameworkCore;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data;

public class PuroguramuDbContext : DbContext
{
    public PuroguramuDbContext(DbContextOptions options)
        :base(options)
    {
    }

    public DbSet<Languages> Languages { get; set; }

    public DbSet<Courses> Courses { get; set; }

    public DbSet<Lessons> Lessons { get; set; }

    public DbSet<Exercises> Exercises { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
