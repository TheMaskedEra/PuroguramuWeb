using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IUserRepository
{
    Task<int> GetTotalStudentNumberAsync();

    Task<bool> RegistrationNumberExistsAsync(string registrationNumber);

    Task<bool> EmailExistsAsync(string email);

    Task<string?> FindEmailFromRegistrationNumber(string registrationNumber);

    Task UpdateAsync(AppUser appUser);
}
