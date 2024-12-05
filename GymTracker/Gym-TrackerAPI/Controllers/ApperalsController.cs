using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using Gym_TrackerDKAPI.Repositories;


namespace Gym_TrackerDKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApperalsController : ControllerBase
    {
        private readonly IApperalService ApperalService;
        public ApperalsController(IApperalService apperalService)
        {
            this.ApperalService = apperalService;
        }
        [HttpGet("ApperalGetAll")]
        public async Task<IEnumerable<Apperal>?> ApperalGetAll(int Apperal_id)
        {
            try
            {
                var response = await ApperalService.ApperalGetAll(Apperal_id);
                if (response == null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}

