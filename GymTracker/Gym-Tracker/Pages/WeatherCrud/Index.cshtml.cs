using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;
using Gym_TrackerAPI.Entities;

namespace Gym_Tracker.Pages.WeatherCrud
{
    public class IndexModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public IndexModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        public IList<WeatherData> WeatherData { get;set; } = default!;

        public async Task OnGetAsync()
        {
            WeatherData = await _context.WeatherData.ToListAsync();
        }
    }
}
