using GymTrackersAPI.Entities;




namespace Gym_TrackerDKAPI.Repositories
{
    public interface IApperalService
    {
        Task<IEnumerable<Apperal>> ApperalGetAll(int apperal_id);
      
    }
}
