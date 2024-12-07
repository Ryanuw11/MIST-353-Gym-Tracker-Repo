using Gym_TrackerDWAPI.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gym_TrackerDWAPI.Repositories
{
    public interface IWeatherRepository
    {
        Task<List<WeatherData>> GetWeather(DateTime date);
    }
}

