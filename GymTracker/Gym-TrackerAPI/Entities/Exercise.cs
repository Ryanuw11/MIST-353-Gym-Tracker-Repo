using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTrackersAPI.Entities
{
    public class Exercise
    {
        [Key]
        [Column ("exercise_id") ]
        public int ExerciseId { get; set; }

        [Column ("exercise_name")]
        
        public string? ExerciseName { get; set; }

        [Column ("exercise_equipment")]
        
        public string? ExerciseEquipment { get; set; }

        [Column ("exercise_muscleTarget")]
        
        public string? ExerciseMuscleTarget { get; set; }
    }
}
