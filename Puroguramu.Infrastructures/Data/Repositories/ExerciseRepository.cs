using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains;
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

    public async Task<int> GetTotalNumberAsync() => await _dbContext.Exercises.CountAsync();

    public Exercise GetExercise(Guid exerciseId) => throw new NotImplementedException();

    public void AddExercise(Exercise exercise) => throw new NotImplementedException();

    public void UpdateExercise(Guid exerciseId) => throw new NotImplementedException();

    public void DeleteExercise(Guid exerciseId) => throw new NotImplementedException();
}
