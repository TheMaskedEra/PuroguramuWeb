namespace Puroguramu.Infrastructures.Data.Entities;

public class ExerciseOrders
{
    public string ExerciseId { get; set; } = string.Empty;

    public Exercises Exercise { get; set; } = null!;

    public string? ExerciseBeforeId { get; set; }

    public Exercises? ExerciseBefore { get; set; }

    public string? ExerciseAfterId { get; set; }

    public Exercises? ExerciseAfter { get; set; }
}
