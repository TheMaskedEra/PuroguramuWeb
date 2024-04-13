namespace Puroguramu.Infrastructures.Data.Entities;

public class ExerciseOrders
{
    public int ExerciseId { get; set; }

    public Exercises Exercise { get; set; } = null!;

    public int? ExerciseBeforeId { get; set; }

    public Exercises? ExerciseBefore { get; set; }

    public int? ExerciseAfterId { get; set; }

    public Exercises? ExerciseAfter { get; set; }
}
