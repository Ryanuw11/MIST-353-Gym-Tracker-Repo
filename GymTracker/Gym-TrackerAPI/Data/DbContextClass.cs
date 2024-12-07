using Gym_TrackerAPI.Entities;
using GymTrackersAPI.Entities;
using Microsoft.EntityFrameworkCore;




namespace GymTrackersAPI.Data
{

    
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }

        public DbSet<UserData> UserData { get; set; }

        public DbSet<GymLoc> GymLoc { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Apperal> Apperal { get; set; }
        public DbSet<CustomerEmail> CustomerEmails { get; set; }
        public DbSet<WeatherData> WeatherData { get; set; }

    }
}
