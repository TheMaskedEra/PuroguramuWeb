using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class ExercisesConfiguration : IEntityTypeConfiguration<Exercises>
{

    public const int Exercise1Id = 1;

    public const int Exercise2Id = 2;

    public const int Exercise3Id = 3;

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
            new() { Id = Exercise1Id, Title = "HelloWorld", Instructions = "Instructions Here", DifficultyLevel = 1, Skeleton = "Skeleton Here", LessonId = LessonsConfiguration.FunctionsId },
            new() { Id = Exercise2Id, Title = "HelloThere", Instructions = "Instructions Here", DifficultyLevel = 1, Skeleton = "Skeleton Here", LessonId = LessonsConfiguration.FunctionsId },
            new() { Id = Exercise3Id, Title = "Obi-Wan", Instructions = "Instructions Here", DifficultyLevel = 1, Skeleton = "Skeleton Here", LessonId = LessonsConfiguration.FunctionsId },

        });
}
