using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTrackersAPI.Entities
{

    
    public class Apperal
    {
        
        [Column("apperal_id")]
        public int ApperalId { get; set; }

        
        [StringLength(255)]
        [Column("apperal_type")]
        public required string ApperalType { get; set; }

        
        [StringLength(255)]
        [Column("apperal_brand")]
        public required string ApperalBrand { get; set; }

        
        [StringLength(255)]
       [Column("apperal_material")]
        public required string ApperalMaterial { get; set; }

        
        [Column("apperal_exercise")]
        public int ApparelExercise { get; set; }
  }
}
