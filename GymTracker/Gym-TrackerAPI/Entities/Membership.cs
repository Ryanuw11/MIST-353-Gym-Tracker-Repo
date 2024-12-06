// Adding what belongs in membership in sql into the API

namespace Gym_TrackerAPI.Entities
{
    public class Membership
    {

        public int ID { get; set; }
        public required string MembershipLevel { get; set; }

        public int MembershipMonthPrice { get; set; }
        public int MembershipMonthLength { get; set; }
    }
}

