using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IUsersRepository
{
    Task InsertAsync(AppUser appUser, string hashedPassword);

    Task UpdateAsync(AppUser appUser);
}
