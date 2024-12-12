using Gym_TrackerAPI.Entities;

namespace Gym_TrackerAPI.Repositiories
{
    public interface IWeatherRepository
    {
        Task<List<WeatherData>> GetWeather(DateTime date);
    }
}
