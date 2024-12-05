using GymTrackersAPI.Repositiories;
using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using System.Linq.Expressions;

namespace GymTrackersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymController : ControllerBase
    {
        private readonly IGymMenu _gymMenu;
        public GymController(IGymMenu gymMenu)
        {

            _gymMenu= gymMenu;
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<List<UserData>>> GetUserDatas(int id)
        {
            var gymDetails = await _gymMenu.GymGetDetails(id);
            return gymDetails;

        }

    }
}
