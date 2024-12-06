using Microsoft.AspNetCore.Mvc;

///Creating Membership Controller
namespace Gym_TrackerAPI.Controllers
{
    namespace Gym_TrackerAPI.Controllers
    {


        [Route("api/[controller]")]
        [ApiController]
        public class MembershipsController : ControllerBase
        {
            private readonly Dictionary<string, decimal> MembershipMonthPrice = new Dictionary<string, decimal>
    {
        { "Bronze", 2.99m },
        { "Silver", 7.99m },
        { "Gold", 9.99m }
    };
            [HttpGet]
            public IEnumerable<string> FetchSomething()
            {
                return MembershipMonthPrice.Keys;
            }

            // Asks for Membership Level
            [HttpGet("{MembershipLevel}", Name = "Get")]
            public IActionResult Get(string MembershipLevel)
            {
                if (MembershipMonthPrice.ContainsKey(MembershipLevel))
                {
                    return Ok(new { MembershipLevel, Price = MembershipMonthPrice[MembershipLevel] });
                }
                else
                {
                    return NotFound("Invalid Membership Level");
                }
            }
        }
    }
}