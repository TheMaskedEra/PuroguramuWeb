using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class LessonOrdersConfiguration : IEntityTypeConfiguration<LessonOrders>
{
    public void Configure(EntityTypeBuilder<LessonOrders> builder)
    {
        builder.HasKey(o => o.LessonId);

        builder.HasOne(o => o.Lesson)
            .WithOne(l => l.Order)
            .HasForeignKey<LessonOrders>(o => o.LessonId);

        builder.HasOne(o => o.LessonBefore)
            .WithOne(l => l.Order)
            .HasForeignKey<LessonOrders>(o => o.LessonBeforeId);

        builder.HasOne(o => o.LessonAfter)
            .WithOne(l => l.Order)
            .HasForeignKey<LessonOrders>(o => o.LessonAfterId);
    }
}
