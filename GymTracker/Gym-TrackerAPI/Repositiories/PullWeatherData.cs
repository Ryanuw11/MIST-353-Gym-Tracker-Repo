using Gym_TrackerDWAPI.Data;
using Gym_TrackerDWAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace Gym_TrackerDWAPI.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly DbContextClass _dbContextClass;

        public WeatherRepository(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<WeatherData>> GetWeather(DateTime date)
        {
            return await _dbContextClass.WeatherData
                .FromSqlRaw("EXEC GetWeather @Date", new SqlParameter("@Date", date))
                .ToListAsync();
        }
    }

}
