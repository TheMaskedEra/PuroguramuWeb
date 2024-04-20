using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface IExerciseRepository
{
    Task<int> GetTotalNumberAsync();

    Exercise GetExercise(Guid exerciseId);

    Task AddExerciseAsync(Exercise exercise);

    Task UpdateExerciseAsync(Exercise exercise);

    Task DeleteExerciseAsync(Exercise exercise);
}
