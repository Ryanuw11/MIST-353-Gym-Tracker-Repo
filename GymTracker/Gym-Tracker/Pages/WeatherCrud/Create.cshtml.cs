using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gym_Tracker.Data;
using Gym_TrackerAPI.Entities;

namespace Gym_Tracker.Pages.WeatherCrud
{
    public class CreateModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public CreateModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WeatherData WeatherData { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WeatherData.Add(WeatherData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
