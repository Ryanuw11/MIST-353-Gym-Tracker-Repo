using System;
using System.Collections.Generic;

namespace Gym_Tracker;

public partial class ExtGymOrg
{
    public int Id { get; set; }

    public string GymName { get; set; } = null!;

    public string GymCity { get; set; } = null!;

    public TimeOnly? OpenTime { get; set; }

    public TimeOnly? CloseTime { get; set; }
}
