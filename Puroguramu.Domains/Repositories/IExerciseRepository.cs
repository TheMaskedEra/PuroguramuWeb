using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IExerciseRepository
{
    Task<int> GetTotalNumberAsync();

    Exercise GetExercise(Guid exerciseId);

    Task AddExerciseAsync(Exercise exercise);

    Task UpdateExerciseAsync(Guid exerciseId);

    Task DeleteExerciseAsync(Guid exerciseId);
}
