using Gym_TrackerAPI.Entities;
using GymTrackersAPI.Data;

namespace Gym_TrackerAPI.Repositiories
{
    //interface for MembershipService
    public class MembershipService : IMembershipService
    {

        public MembershipService(DbContextClass dbContextClass)
        {
        }

        public Task<List<Membership>> MembershipLevelLength(int Membership_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Membership>> MembershipLevelLength(string membershipLevel)
        {
            throw new NotImplementedException();
        }
    }

}