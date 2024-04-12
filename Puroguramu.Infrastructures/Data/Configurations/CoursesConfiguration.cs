using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class CoursesConfiguration : IEntityTypeConfiguration<Courses>
{
    public const int CSharpBeginnersId = 1;

    public const int CSharpAmateursId = 2;

    public void Configure(EntityTypeBuilder<Courses> builder)
    {
        builder.HasOne(c => c.Language)
            .WithMany(l => l.Courses)
            .HasForeignKey(e => e.LanguageId);

        builder.HasAlternateKey(c => new {c.Title, c.LanguageId});

        SeedData(builder);
    }

    private static void SeedData(EntityTypeBuilder<Courses> builder) =>
        builder.HasData(new List<Courses>
        {
            new() { Id = CSharpBeginnersId, Title = "Beginners", LanguageId = LanguagesConfiguration.CSharpId},
            new() { Id = CSharpAmateursId, Title = "Amateurs", LanguageId = LanguagesConfiguration.CSharpId},
        });
}
