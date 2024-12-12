using Gym_TrackerAPI.Entities;
using GymTrackersAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gym_TrackerAPI.Repositiories
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