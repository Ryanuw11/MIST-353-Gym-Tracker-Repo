using Gym_TrackerDWAPI.Data;
using Gym_TrackerDWAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gym_TrackerDWAPI.Repositories
{
    public class EmailInput : IEmailInput
    {
        private readonly DbContextClass _dbContextClass;

        public EmailInput(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<CustomerEmail>> Customer_Email_Input(string email)
        {
            var param = new SqlParameter("@Email", email);
            var customerEmails = await _dbContextClass.CustomerEmails
                .FromSqlRaw("exec Customer_Email_Input @Email", param).ToListAsync();
            return customerEmails;
        }
    }
}
