using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerAPI.Entities
{
    public class WeatherData
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Temp { get; set; }
        public int ChanceOfRain { get; set; }

        public WeatherData() { }

        public WeatherData(DateTime date, int temp, int chanceOfRain)
        {
            Date = date;
            Temp = temp;
            ChanceOfRain = chanceOfRain;
        }
    }
}
