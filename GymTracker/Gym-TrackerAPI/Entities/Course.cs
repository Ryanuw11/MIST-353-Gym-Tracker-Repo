using System.ComponentModel.DataAnnotations;

// Adding Course information from SQL

namespace Gym_TrackerAPI.Entities
{
    public class Course
    {
        [Key]
        public int CID { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(255)]
        public int LengthMinutes { get; set; }

        [Required]
        [StringLength(255)]
        public string TrainerFirstName { get; set; }


        [Required]
        [StringLength(255)]
        public string TrainerLastName { get; set; }


        [Required]
        [StringLength(255)]
        public int ClassPrice { get; set; }



    }
}