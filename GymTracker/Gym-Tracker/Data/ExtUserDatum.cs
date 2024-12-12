using System;
using System.Collections.Generic;

namespace Gym_Tracker.Data;

public partial class ExtUserDatum
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int UserPassword { get; set; }

    public string UserEmail { get; set; } = null!;

    public string UserAddress { get; set; } = null!;

    public string UserCity { get; set; } = null!;

    public DateOnly? UserJoined { get; set; }

    public string UserLevel { get; set; } = null!;
}
