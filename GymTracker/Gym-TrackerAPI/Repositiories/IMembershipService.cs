using Gym_TrackerAPI.Entities;
namespace Gym_TrackerAPI.Repositiories
{
    public interface IMembershipService
    {
        public Task<List<Membership>> MembershipLevelLength(int Membership_ID);
        Task<List<Membership>> MembershipLevelLength(string membershipLevel);
    }
}
