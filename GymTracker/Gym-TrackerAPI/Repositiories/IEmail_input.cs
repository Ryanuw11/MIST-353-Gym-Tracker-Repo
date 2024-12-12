using Gym_TrackerAPI.Entities;

namespace Gym_TrackerAPI.Repositiories
{
    public interface IEmailInput
    {
        Task<List<CustomerEmail>> Customer_Email_Input(string email);
    }
}
