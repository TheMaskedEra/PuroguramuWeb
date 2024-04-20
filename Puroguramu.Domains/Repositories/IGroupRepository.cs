namespace Puroguramu.Domains.Repositories;

public interface IGroupRepository
{
    Task<List<string>> GetAllGroupNamesAsync();

    Task<string?> GetGroupIdFromName(string groupName); //TODO Trouver un autre moyen que models qui possède id
}
