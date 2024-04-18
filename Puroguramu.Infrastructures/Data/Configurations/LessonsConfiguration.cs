using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class LessonsConfiguration : IEntityTypeConfiguration<Lessons>
{
    public static readonly Guid VariablesId = Guid.NewGuid();

    public static readonly Guid FunctionsId = Guid.NewGuid();

    public static readonly Guid ClassesId = Guid.NewGuid();

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
            new() { Id = VariablesId.ToString(), CourseId = CoursesConfiguration.CSharpBeginnersId.ToString(), Title = "Variables", IsVisible = true },
            new() { Id = FunctionsId.ToString(), CourseId = CoursesConfiguration.CSharpBeginnersId.ToString(), Title = "Functions", IsVisible = true},
            new() { Id =  ClassesId.ToString(), CourseId = CoursesConfiguration.CSharpBeginnersId.ToString(), Title = "Classes", IsVisible = true},
        });
}
