using Gym_TrackerDWAPI.Entities;

namespace Gym_TrackerDWAPI.Repositories
{
    public interface IEmailInput
    {
        Task<List<CustomerEmail>> Customer_Email_Input(string email);
    }
}
