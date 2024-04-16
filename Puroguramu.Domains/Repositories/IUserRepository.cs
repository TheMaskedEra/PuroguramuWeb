using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IUserRepository
{
    Task<int> GetTotalStudentNumberAsync();

    Task InsertAsync(AppUser appUser, string hashedPassword);

    Task UpdateAsync(AppUser appUser);
}
