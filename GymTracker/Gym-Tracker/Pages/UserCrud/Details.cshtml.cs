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
    public class DetailsModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public DetailsModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

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
    }
}
