using System;
using System.Collections.Generic;

namespace Gym_Tracker;

public partial class CustomerEmail
{
    public string Email { get; set; } = null!;

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
