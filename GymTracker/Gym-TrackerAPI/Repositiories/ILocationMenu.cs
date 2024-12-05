using GymTrackersAPI.Entities;
namespace Gym_TrackerAPI.Repositiories
{
    public interface ILocationMenu
    {
        public Task<List<GymLoc>> LocationGetDetails(string gym_name);
    }
}
