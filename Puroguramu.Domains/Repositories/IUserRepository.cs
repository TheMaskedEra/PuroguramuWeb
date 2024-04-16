using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IUserRepository
{
    Task<int> GetTotalStudentNumberAsync();

    void Insert(AppUser appUser, string hashedPassword);

    void Update(AppUser appUser);
}
