using System;
using System.Collections.Generic;

namespace Gym_Tracker.Data;

public partial class ExtExercise
{
    public int ExerciseId { get; set; }

    public string ExerciseName { get; set; } = null!;

    public string? ExerciseEquipment { get; set; }

    public string ExerciseMuscleTarget { get; set; } = null!;

    public virtual ICollection<ExtExerciseApperal> ExtExerciseApperals { get; set; } = new List<ExtExerciseApperal>();
}
