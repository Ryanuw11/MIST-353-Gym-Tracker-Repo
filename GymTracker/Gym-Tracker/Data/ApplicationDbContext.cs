using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymTrackersAPI.Entities;
using Gym_TrackerAPI.Entities;

namespace Gym_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Membership> Membership { get; set; } = default!;
        public DbSet<UserData> UserData { get; set; } = default!;
    }
}



