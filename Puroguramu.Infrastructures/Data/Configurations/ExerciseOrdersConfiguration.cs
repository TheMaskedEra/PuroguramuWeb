using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class ExerciseOrdersConfiguration : IEntityTypeConfiguration<ExerciseOrders>
{
    public void Configure(EntityTypeBuilder<ExerciseOrders> builder)
    {
        builder.HasKey(eo => eo.ExerciseId);

        builder.HasOne(eo => eo.ExerciseBefore)
            .WithMany()
            .HasForeignKey(eo => eo.ExerciseBeforeId);

        builder.HasOne(eo => eo.ExerciseAfter)
            .WithMany()
            .HasForeignKey(eo => eo.ExerciseAfterId);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<ExerciseOrders> builder) =>
        builder.HasData(new List<ExerciseOrders>
        {
            new() { ExerciseId = ExercisesConfiguration.Exercise1Id, ExerciseAfterId = ExercisesConfiguration.Exercise2Id },
            new() { ExerciseId = ExercisesConfiguration.Exercise2Id, ExerciseBeforeId = ExercisesConfiguration.Exercise1Id, ExerciseAfterId = ExercisesConfiguration.Exercise3Id },
            new() { ExerciseId = ExercisesConfiguration.Exercise3Id, ExerciseBeforeId = ExercisesConfiguration.Exercise2Id },
        });
}
