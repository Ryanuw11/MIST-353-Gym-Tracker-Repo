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
    public class DeleteModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public DeleteModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WeatherData WeatherData { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherdata = await _context.WeatherData.FirstOrDefaultAsync(m => m.Id == id);

            if (weatherdata == null)
            {
                return NotFound();
            }
            else
            {
                WeatherData = weatherdata;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherdata = await _context.WeatherData.FindAsync(id);
            if (weatherdata != null)
            {
                WeatherData = weatherdata;
                _context.WeatherData.Remove(WeatherData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
