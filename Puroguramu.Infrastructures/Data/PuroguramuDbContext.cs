using Microsoft.AspNetCore.Identity;
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

    public DbSet<Users> AppUsers { get; set; }

    public DbSet<Languages> Languages { get; set; }

    public DbSet<Courses> Courses { get; set; }

    public DbSet<LessonOrders> LessonOrders { get; set; }

    public DbSet<Lessons> Lessons { get; set; }

    public DbSet<ExerciseOrders> ExerciseOrders { get; set; }

    public DbSet<Exercises> Exercises { get; set; }

    public DbSet<Groups> Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new LanguagesConfiguration());
        builder.ApplyConfiguration(new CoursesConfiguration());
        builder.ApplyConfiguration(new LessonsConfiguration());
        builder.ApplyConfiguration(new LessonOrdersConfiguration());
        builder.ApplyConfiguration(new ExercisesConfiguration());
        builder.ApplyConfiguration(new ExerciseOrdersConfiguration());
        builder.ApplyConfiguration(new GroupsConfiguration());

        builder.ApplyConfiguration(new IdentityRoleConfiguration());
        builder.ApplyConfiguration(new IdentityUserConfiguration());
    }
}
