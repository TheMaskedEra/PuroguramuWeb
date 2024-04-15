using Puroguramu.Domains;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class ExercisesRepository : IExercisesRepository
{
    public Exercise GetExercise(Guid exerciseId)
        => new Exercise();
}
