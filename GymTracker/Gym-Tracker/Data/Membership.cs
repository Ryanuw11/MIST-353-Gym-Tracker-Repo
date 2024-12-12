using System;
using System.Collections.Generic;

namespace Gym_Tracker.Data;

public partial class Membership
{
    public int Id { get; set; }

    public string MembershipLevel { get; set; } = null!;

    public decimal? MembershipMonthPrice { get; set; }

    public int? MembershipMonthLength { get; set; }


}
