using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.ExerciseCrud
{
    public class DetailsModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public DetailsModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        public Gym_Tracker.Data.ExtExercise ExtExercise { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extexercise = await _context.ExtExercises.FirstOrDefaultAsync(m => m.ExerciseId == id);
            if (extexercise == null)
            {
                return NotFound();
            }
            else
            {
                ExtExercise = extexercise;
            }
            return Page();
        }
    }
}
