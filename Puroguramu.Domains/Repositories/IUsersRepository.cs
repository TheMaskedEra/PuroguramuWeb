using Puroguramu.Domains.Entities;

namespace Puroguramu.Domains.Repositories;

public interface IUsersRepository
{
    Task InsertAsync(AppUser appUser);

    Task UpdateAsync(AppUser appUser);
}
