using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class LanguagesRepository : ILanguageRepository
{
    private readonly PuroguramuDbContext _dbContext;

    public LanguagesRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<string?> FindLanguageIdAsync(string languageName) =>
        await _dbContext.Languages
            .Where(l => l.Name.Equals(languageName))
            .Select(l => l.Id)
            .FirstOrDefaultAsync() ?? string.Empty;
}
