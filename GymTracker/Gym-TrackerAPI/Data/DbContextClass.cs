using GymTrackersAPI.Entities;
using Microsoft.EntityFrameworkCore;





namespace GymTrackersAPI.Data
{

    
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }

        public DbSet<UserData> UserData { get; set; }

        public DbSet<GymLoc> GymLoc { get; set; }
    }
}
