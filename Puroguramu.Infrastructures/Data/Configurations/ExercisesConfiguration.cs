using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class ExercisesConfiguration : IEntityTypeConfiguration<Exercises>
{
    public static readonly Guid Exercise1Id = Guid.NewGuid();

    public static readonly Guid Exercise2Id = Guid.NewGuid();

    public static readonly Guid Exercise3Id = Guid.NewGuid();

    public void Configure(EntityTypeBuilder<Exercises> builder)
    {
        builder.HasIndex(e => new { e.Title, e.LessonId }).IsUnique();

        builder.HasOne(e => e.Lesson)
            .WithMany(l => l.Exercises)
            .HasForeignKey(e => e.LessonId);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Exercises> builder) =>
        builder.HasData(new List<Exercises>
        {
            new() { Id = Exercise1Id.ToString(), Title = "HelloWorld", Instructions = "Instructions Here", DifficultyLevel = 1, Skeleton = "Skeleton Here", LessonId = LessonsConfiguration.FunctionsId.ToString() },
            new() { Id = Exercise2Id.ToString(), Title = "HelloThere", Instructions = "Instructions Here", DifficultyLevel = 1, Skeleton = "Skeleton Here", LessonId = LessonsConfiguration.FunctionsId.ToString() },
            new() { Id = Exercise3Id.ToString(), Title = "Obi-Wan", Instructions = "Instructions Here", DifficultyLevel = 1, Skeleton = "Skeleton Here", LessonId = LessonsConfiguration.FunctionsId.ToString() },
        });
}
