using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class GroupsConfiguration : IEntityTypeConfiguration<Groups>
{

    public static readonly Guid FirstGroupId = Guid.NewGuid();

    public static readonly Guid SecondGroupId = Guid.NewGuid();

    public static readonly Guid ThirdGroupId = Guid.NewGuid();

    public static readonly Guid FourthGroupId = Guid.NewGuid();

    public void Configure(EntityTypeBuilder<Groups> builder)
    {
        builder.HasIndex(g => g.Name).IsUnique();

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Groups> builder) =>
        builder.HasData(new List<Groups>
        {
            new() { Id = FirstGroupId.ToString(), Name = "2i1" },
            new() { Id = SecondGroupId.ToString(), Name = "2i2" },
            new() { Id = ThirdGroupId.ToString(), Name = "2i3" },
            new() { Id = FourthGroupId.ToString(), Name = "2i4" },
        });
}
