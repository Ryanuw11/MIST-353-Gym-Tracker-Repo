using System;
using System.Collections.Generic;

namespace Gym_Tracker.Data;

public partial class ExtExerciseApperal
{
    public int ApperalId { get; set; }

    public string ApperalType { get; set; } = null!;

    public string ApperalBrand { get; set; } = null!;

    public string ApperalMaterial { get; set; } = null!;

    public int ApperalExercise { get; set; }

    public virtual ExtExercise ApperalExerciseNavigation { get; set; } = null!;
}
