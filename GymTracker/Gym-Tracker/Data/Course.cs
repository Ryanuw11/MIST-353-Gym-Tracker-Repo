using System;
using System.Collections.Generic;

namespace Gym_Tracker.Data;

public partial class Course
{
    public int Cid { get; set; }

    public string CourseName { get; set; } = null!;

    public int LengthMinutes { get; set; }

    public string TrainerFirstName { get; set; } = null!;

    public string TrainerLastName { get; set; } = null!;

    public decimal ClassPrice { get; set; }
}
