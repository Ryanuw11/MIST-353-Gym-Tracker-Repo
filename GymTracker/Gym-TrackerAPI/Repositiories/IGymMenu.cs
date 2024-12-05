using GymTrackersAPI.Entities;
namespace GymTrackersAPI.Repositiories
{
    public interface IGymMenu
    {
        public Task<List<UserData>> GymGetDetails(int id);
    }
}
