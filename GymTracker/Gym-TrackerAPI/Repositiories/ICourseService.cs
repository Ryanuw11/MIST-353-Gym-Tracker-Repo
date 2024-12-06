using Gym_TrackerAPI.Entities;
//Course Service Interface

namespace Gym_TrackerAPI.Repositiories
{
    public interface ICourseService
    {
        public Task<List<Course>> ClassP(int @ClassPrice);
    }
}