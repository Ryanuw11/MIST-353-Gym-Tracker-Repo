using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.ApparalCrud
{
    public class EditModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public EditModel(Gym_Tracker.Data.GymTrackerDbContext context)
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

            var extexerciseapperal =  await _context.ExtExerciseApperals.FirstOrDefaultAsync(m => m.ApperalId == id);
            if (extexerciseapperal == null)
            {
                return NotFound();
            }
            ExtExerciseApperal = extexerciseapperal;
           ViewData["ApperalExercise"] = new SelectList(_context.ExtExercises, "ExerciseId", "ExerciseId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ExtExerciseApperal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtExerciseApperalExists(ExtExerciseApperal.ApperalId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExtExerciseApperalExists(int id)
        {
            return _context.ExtExerciseApperals.Any(e => e.ApperalId == id);
        }
    }
}
