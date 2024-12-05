using GymTrackersAPI.Data;
using GymTrackersAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Gym_TrackerDKAPI.Repositories
{
    public class ApperalService : IApperalService
    {
        private readonly DbContextClass _dbContext;
        public ApperalService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<Apperal>> ApperalGetAll(int apperal_id)

        {
            var param = new SqlParameter("@apperal_id", apperal_id);
            var apperalDetails = await Task.Run(() => _dbContext.Apperal
              .FromSqlRaw(@"exec spApperalGetAll @apperal_id", param).ToListAsync());
            return apperalDetails;
        }


    }
}