using GymTrackerAPI.Repositiories;
using GymTrackersAPI.Data;
using GymTrackersAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerDKAPI.Repositories
{
    public class ExerciseService : IExerciseService
    {
        private readonly DbContextClass _dbContext;
        public ExerciseService(DbContextClass dbContext)
       {
            _dbContext = dbContext;
       }

       
         public async Task<IEnumerable<Exercise>> ExerciseGetEquipment(int exercise_id)

        {
         var param = new SqlParameter("@exercise_id", exercise_id);
            var query = "exec spExerciseGetEquipment @exercise_id";
            var response = await _dbContext.Exercise
                .FromSqlRaw(query, param)
                .AsNoTracking()
                .ToListAsync();

            if (response == null)
            {
                return null;
            }
            return response;
        }
        public async Task<IEnumerable<Exercise>?> ExerciseGetAll(int exercise_id)

        {
            var param = new SqlParameter("@exercise_id", exercise_id);
            var exerciseDetails = await Task.Run(() => _dbContext.Exercise
              .FromSqlRaw(@"exec spExerciseGetAll @exercise_id", param).ToListAsync());
            return exerciseDetails;
        }

    }


}


