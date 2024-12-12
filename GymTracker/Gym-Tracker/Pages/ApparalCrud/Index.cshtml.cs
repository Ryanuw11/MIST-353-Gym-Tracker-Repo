using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.ApparalCrud
{
    public class IndexModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public IndexModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        public IList<ExtExerciseApperal> ExtExerciseApperal { get;set; } = default!;

        public async Task OnGetAsync(string apperalID)
        {
            if (!string.IsNullOrEmpty(apperalID))
            {
                // Assuming ApperalId is an integer, otherwise adjust the filter accordingly
                ExtExerciseApperal = await _context.ExtExerciseApperals
                    .Where(a => a.ApperalId.ToString() == apperalID) // Filter by ApperalId
                    .Include(e => e.ApperalExerciseNavigation)
                    .ToListAsync();
            }
            else
            {
                // If no ApperalID is provided, return all records
                ExtExerciseApperal = await _context.ExtExerciseApperals
                    .Include(e => e.ApperalExerciseNavigation)
                    .ToListAsync();
            }
        }
    }
}
    

