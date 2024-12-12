using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.GymLocCrud
{
    public class EditModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public EditModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Gym_Tracker.Data.ExtGymOrg ExtGymOrg { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extgymorg =  await _context.ExtGymOrgs.FirstOrDefaultAsync(m => m.Id == id);
            if (extgymorg == null)
            {
                return NotFound();
            }
            ExtGymOrg = extgymorg;
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

            _context.Attach(ExtGymOrg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtGymOrgExists(ExtGymOrg.Id))
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

        private bool ExtGymOrgExists(int id)
        {
            return _context.ExtGymOrgs.Any(e => e.Id == id);
        }
    }
}
