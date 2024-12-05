using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using System.Linq.Expressions;
using GymTrackerAPI.Repositiories;
using Gym_TrackerDKAPI.Repositories;

namespace Gym_TrackerDKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService ExerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            this.ExerciseService = exerciseService;
        }
   
       
        [HttpGet("ExerciseGetAll")]
        public async Task<IEnumerable<Exercise>?> ExerciseGetAll(int Exercise_id)
        {
            try
            {
                var response = await ExerciseService.ExerciseGetAll(Exercise_id);
                if (response == null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}

