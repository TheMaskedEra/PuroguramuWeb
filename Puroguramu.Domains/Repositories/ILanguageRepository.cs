namespace Puroguramu.Domains.Repositories;

public interface ILanguageRepository
{
    public Task<string?> FindLanguageIdAsync(string languageName);
}
