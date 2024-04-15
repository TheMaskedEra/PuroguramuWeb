using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data.Configurations;

public class CoursesConfiguration : IEntityTypeConfiguration<Courses>
{
    public static readonly Guid CSharpBeginnersId = Guid.NewGuid();

    public static readonly Guid CSharpAmateursId = Guid.NewGuid();

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
            new() { Id = CSharpBeginnersId.ToString(), Title = "Beginners", LanguageId = LanguagesConfiguration.CSharpId.ToString() },
            new() { Id = CSharpAmateursId.ToString(), Title = "Amateurs", LanguageId = LanguagesConfiguration.CSharpId.ToString() },
        });
}
