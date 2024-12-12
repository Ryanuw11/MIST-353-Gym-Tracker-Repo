using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.UserCrud
{
    public class DeleteModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public DeleteModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExtUserDatum ExtUserDatum { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extuserdatum = await _context.ExtUserData.FirstOrDefaultAsync(m => m.Id == id);

            if (extuserdatum == null)
            {
                return NotFound();
            }
            else
            {
                ExtUserDatum = extuserdatum;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extuserdatum = await _context.ExtUserData.FindAsync(id);
            if (extuserdatum != null)
            {
                ExtUserDatum = extuserdatum;
                _context.ExtUserData.Remove(ExtUserDatum);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
