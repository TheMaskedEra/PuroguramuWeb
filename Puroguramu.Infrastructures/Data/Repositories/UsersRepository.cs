using Puroguramu.Domains.Entities;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class UsersRepository : IUsersRepository
{
    public Task InsertAsync(AppUser appUser) => throw new NotImplementedException();

    public Task UpdateAsync(AppUser appUser) => throw new NotImplementedException();
}
