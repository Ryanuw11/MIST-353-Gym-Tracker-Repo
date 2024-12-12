using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.UserCrud
{
    public class EditModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public EditModel(Gym_Tracker.Data.GymTrackerDbContext context)
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

            var extuserdatum =  await _context.ExtUserData.FirstOrDefaultAsync(m => m.Id == id);
            if (extuserdatum == null)
            {
                return NotFound();
            }
            ExtUserDatum = extuserdatum;
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

            _context.Attach(ExtUserDatum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtUserDatumExists(ExtUserDatum.Id))
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

        private bool ExtUserDatumExists(int id)
        {
            return _context.ExtUserData.Any(e => e.Id == id);
        }
    }
}
