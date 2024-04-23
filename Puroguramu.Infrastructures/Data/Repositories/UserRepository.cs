using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PuroguramuDbContext _dbContext;

    private readonly EntitiesModelMapper _mapper = new();

    public UserRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //TODO Rajouter le filtre role étudiant
    public async Task<int> GetTotalStudentNumberAsync()
        => await _dbContext.Users.CountAsync();

    public async Task<bool> RegistrationNumberExistsAsync(string registrationNumber)
        => await _dbContext.Users.AnyAsync(u => u.RegistrationNumber.Equals(registrationNumber));

    public async Task<bool> EmailExistsAsync(string email)
        => await _dbContext.Users.AnyAsync(u => u.Email.Equals(email));

    public async Task<string?> FindEmailFromRegistrationNumber(string registrationNumber)
        => await _dbContext.Users
            .Where(u => u.RegistrationNumber.Equals(registrationNumber))
            .Select(u => u.Email)
            .FirstOrDefaultAsync();

    public Task UpdateAsync(AppUser appUser)
        => throw new NotImplementedException();
}
