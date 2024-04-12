using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class LanguagesConfiguration : IEntityTypeConfiguration<Languages>
{
    public const int CSharpId = 1;

    public const int JavaId = 2;

    public void Configure(EntityTypeBuilder<Languages> builder)
    {
        builder.HasAlternateKey(l => l.Name);

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Languages> builder) =>
        builder.HasData(new List<Languages>
        {
            new() {Id = CSharpId, Name = "C#"},
            new() {Id = JavaId, Name =" Java"},
        });
}
