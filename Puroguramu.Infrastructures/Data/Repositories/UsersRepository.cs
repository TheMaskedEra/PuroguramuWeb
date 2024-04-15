using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly PuroguramuDbContext _dbContext;

    private readonly EntitiesModelMapper _mapper = new();

    public UsersRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task InsertAsync(AppUser appUser, string hashedPassword)
    {
        await using (_dbContext)
        {
            var group = _dbContext.Groups
                .FirstOrDefault(g => g.Name.Equals(appUser.Group));

            if (group == null)
            {
                throw new Exception("Group not found"); //TODO
            }

            var userDto = _mapper.UserToEFUser(appUser, group.Id);
            userDto.PasswordHash = hashedPassword;

            _dbContext.Users.Add(userDto);

            await _dbContext.SaveChangesAsync();
        }
    }

    public Task UpdateAsync(AppUser appUser) => throw new NotImplementedException();
}
