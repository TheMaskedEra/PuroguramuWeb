using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IUserRepository
{
    int GetTotalNumber();

    void Insert(AppUser appUser, string hashedPassword);

    void Update(AppUser appUser);
}
