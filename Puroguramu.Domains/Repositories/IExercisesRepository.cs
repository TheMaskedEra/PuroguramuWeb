namespace Puroguramu.Domains.Repositories;

public interface IExercisesRepository
{
    Exercise GetExercise(Guid exerciseId);
}
