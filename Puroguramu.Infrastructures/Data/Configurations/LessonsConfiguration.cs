using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class LessonsConfiguration : IEntityTypeConfiguration<Lessons>
{
    public const int VariablesId = 1;

    public const int FunctionsId = 2;

    public void Configure(EntityTypeBuilder<Lessons> builder)
    {
        builder.HasAlternateKey(l => l.Title);

        builder.HasOne(l => l.Course)
            .WithMany(c => c.Lessons)
            .HasForeignKey(l => l.CourseId);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Lessons> builder) =>
        builder.HasData(new List<Lessons>
        {
            new() { Id = VariablesId, CourseId = CoursesConfiguration.CSharpBeginnersId, Title = "Variables", IsVisible = true },
            new() { Id = FunctionsId, CourseId = CoursesConfiguration.CSharpBeginnersId, Title = "Functions"},
        });
}
