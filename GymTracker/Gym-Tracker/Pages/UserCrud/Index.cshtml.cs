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
    public class IndexModel : PageModel
    {
        private readonly Gym_Tracker.Data.GymTrackerDbContext _context;

        public IndexModel(Gym_Tracker.Data.GymTrackerDbContext context)
        {
            _context = context;
        }

        public IList<ExtUserDatum> ExtUserDatum { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ExtUserDatum = await _context.ExtUserData.ToListAsync();
        }
    }
}
