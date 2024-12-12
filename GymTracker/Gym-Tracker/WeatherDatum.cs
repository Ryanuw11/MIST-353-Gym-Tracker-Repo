using System;
using System.Collections.Generic;

namespace Gym_Tracker;

public partial class WeatherDatum
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int? ChanceOfRain { get; set; }

    public int? Temp { get; set; }
}
