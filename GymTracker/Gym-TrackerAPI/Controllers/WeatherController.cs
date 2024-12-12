using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using Gym_TrackerAPI.Repositiories;
using Gym_TrackerAPI.Entities;
namespace Gym_TrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherController(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        // Endpoint to get weather data for a specific date
        [HttpGet("WeatherData")]
        public async Task<ActionResult<List<WeatherData>>> GetWeather(DateTime date)
        {
            try
            {
                var weatherData = await _weatherRepository.GetWeather(date);
                if (weatherData == null || weatherData.Count == 0)
                {
                    return NotFound("No weather data found for the specified date.");
                }

                return Ok(weatherData);
            }
            catch (Exception ex)
            {
                // Log the exception (you can replace this with a logging framework like Serilog)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
