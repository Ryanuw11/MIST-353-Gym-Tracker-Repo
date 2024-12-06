using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using GymTrackersAPI.Data;


//Adding class price to the API

namespace Gym_TrackerAPI.Repositories
{
    //interface for CourseService
    public class CourseService : ICourseService
    {
        private readonly DbContextClass CourseData;

        public CourseService(DbContextClass CourseData)
        {
            CourseData = CourseData;
        }

        public Task<List<Course>> ClassP(int @ClassPrice)
        {
            throw new NotImplementedException();
        }


    }
}