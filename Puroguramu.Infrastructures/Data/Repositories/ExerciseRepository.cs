using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class ExerciseRepository : IExerciseRepository
{
    private readonly PuroguramuDbContext _dbContext;

    private readonly EntitiesModelMapper _mapper = new();

    public ExerciseRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> GetTotalNumberAsync()
        => await _dbContext.Exercises.CountAsync();

    public Exercise GetExercise(Guid exerciseId)
        => throw new NotImplementedException();

    public async Task AddExerciseAsync(Exercise exercise)
    {
        var exerciseDto = _mapper.ExerciseToExerciseDto(exercise);
        _dbContext.Exercises.Add(exerciseDto);

        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateExerciseAsync(Exercise exercise)
        => throw new NotImplementedException();

    public async Task DeleteExerciseAsync(Exercise exercise)
        => throw new NotImplementedException();
}
