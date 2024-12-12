using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Data;

namespace Gym_Tracker.Pages.GymLocCrud
{
    public class DetailsModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public DetailsModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        public Gym_Tracker.Data.ExtGymOrg ExtGymOrg { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extgymorg = await _context.ExtGymOrgs.FirstOrDefaultAsync(m => m.Id == id);
            if (extgymorg == null)
            {
                return NotFound();
            }
            else
            {
                ExtGymOrg = extgymorg;
            }
            return Page();
        }
    }
}
