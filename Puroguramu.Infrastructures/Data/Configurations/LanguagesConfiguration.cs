using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class LanguagesConfiguration : IEntityTypeConfiguration<Languages>
{
    public static readonly Guid CSharpId = Guid.NewGuid();

    public static readonly Guid JavaId = Guid.NewGuid();

    public void Configure(EntityTypeBuilder<Languages> builder)
    {
        builder.HasAlternateKey(l => l.Name);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Languages> builder) =>
        builder.HasData(new List<Languages>
        {
            new() {Id = CSharpId.ToString(), Name = "C#"},
            new() {Id = JavaId.ToString(), Name = "Java"},
        });
}
