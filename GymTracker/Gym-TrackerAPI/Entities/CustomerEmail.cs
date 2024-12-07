using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerDWAPI.Entities
{
    public class CustomerEmail
    {
        [Key]
        public string Email { get; set; } = string.Empty;

        public CustomerEmail() { }

        public CustomerEmail(string email)
        {
            Email = email;
        }
    }
}

