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
    public class DeleteModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public DeleteModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExtExerciseApperal ExtExerciseApperal { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extexerciseapperal = await _context.ExtExerciseApperals.FirstOrDefaultAsync(m => m.ApperalId == id);

            if (extexerciseapperal == null)
            {
                return NotFound();
            }
            else
            {
                ExtExerciseApperal = extexerciseapperal;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extexerciseapperal = await _context.ExtExerciseApperals.FindAsync(id);
            if (extexerciseapperal != null)
            {
                ExtExerciseApperal = extexerciseapperal;
                _context.ExtExerciseApperals.Remove(ExtExerciseApperal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
