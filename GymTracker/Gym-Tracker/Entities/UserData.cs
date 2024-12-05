using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTrackersAPI.Entities
{
    public class UserData
    {





        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        public string? UserName { get; set; }

        [Column("user_password")]
        public int UserPassword { get; set; }

        [Column("user_email")]
        public string? UserEmail { get; set; }

        [Column("user_address")]
        public string? UserAddress { get; set; }

        [Column("user_city")]
        public string? UserCity { get; set; }

        [Column("user_joined")]
        public DateTime? UserJoined { get; set; }

        [Column("user_level")]
        public string? UserLevel { get; set; }
    }
}

