namespace Puroguramu.Domains.Repositories;

public interface IExerciseRepository
{
    Task<int> GetTotalNumberAsync();

    Exercise GetExercise(Guid exerciseId);

    void AddExercise(Exercise exercise);

    void UpdateExercise(Guid exerciseId);

    void DeleteExercise(Guid exerciseId);
}
