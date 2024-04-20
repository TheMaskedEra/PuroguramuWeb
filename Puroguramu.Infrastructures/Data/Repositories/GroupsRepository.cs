using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class GroupsRepository : IGroupRepository
{
    private readonly PuroguramuDbContext _dbContext;

    public GroupsRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<string>> GetAllGroupNamesAsync()
        => await _dbContext.Groups.Select(g => g.Name).ToListAsync();

    public async Task<string?> GetGroupIdFromName(string groupName)
        => await _dbContext.Groups.Select(g => g.Name)
            .Where(name => name.Equals(groupName))
            .FirstOrDefaultAsync();
}
