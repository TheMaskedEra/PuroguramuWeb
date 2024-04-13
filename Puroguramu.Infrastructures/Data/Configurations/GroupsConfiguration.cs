using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class GroupsConfiguration : IEntityTypeConfiguration<Groups>
{
    public void Configure(EntityTypeBuilder<Groups> builder)
    {
        builder.HasIndex(g => g.Name).IsUnique();

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Groups> builder) =>
        builder.HasData(new List<Groups>
        {
            new() { Id = 1, Name = "2i1" },
            new() { Id = 2, Name = "2i2" },
            new() { Id = 3, Name = "2i3" },
            new() { Id = 4, Name = "2i4" },
        });
}
