using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GymTrackersAPI.Entities
{
    public class GymLoc
    {
        [Key]  
        [Column("id")]
        public int Id { get; set; }

        [Column("gym_name")]
        public string? GymName { get; set; }

        [Column("gym_city")]
        public string? GymCity { get; set; }

        [Column("open_time")]
        public TimeSpan? OpenTime { get; set; } 

        [Column("close_time")]
        public TimeSpan? CloseTime { get; set; } 
    }
}
