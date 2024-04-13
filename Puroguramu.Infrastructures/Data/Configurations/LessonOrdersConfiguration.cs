using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class LessonOrdersConfiguration : IEntityTypeConfiguration<LessonOrders>
{
    public void Configure(EntityTypeBuilder<LessonOrders> builder)
    {
        builder.HasKey(lo => lo.LessonId);

        builder.HasOne(lo => lo.Lesson)
            .WithOne(l => l.Order)
            .HasForeignKey<LessonOrders>(lo => lo.LessonId);

        builder.HasOne(lo => lo.LessonBefore)
            .WithMany()
            .HasForeignKey(lo => lo.LessonBeforeId);

        builder.HasOne(lo => lo.LessonAfter)
            .WithMany()
            .HasForeignKey(lo => lo.LessonAfterId);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<LessonOrders> builder) =>
        builder.HasData(new List<LessonOrders>
        {
            new() { LessonId = LessonsConfiguration.VariablesId, LessonAfterId = LessonsConfiguration.FunctionsId },
            new() { LessonId = LessonsConfiguration.FunctionsId, LessonBeforeId = LessonsConfiguration.VariablesId, LessonAfterId = LessonsConfiguration.ClassesId },
            new() { LessonId = LessonsConfiguration.ClassesId, LessonBeforeId = LessonsConfiguration.FunctionsId },
        });
}
