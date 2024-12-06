using Microsoft.AspNetCore.Mvc;


namespace Gym_TrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        string[] CoursePrice = { "1.99", "2.99", "3", "9.99", "3.99", "4.99", "5.99", "6.99" };


        [HttpGet]

        public IEnumerable<string> FetchSomething()
        {
            return CoursePrice;
        }
        //asks for CoursePrice

        [HttpGet("{courseIndex}")]
        public IActionResult Get(int courseIndex)
        {
            // Validate the index
            if (courseIndex < 0 || courseIndex >= CoursePrice.Length)
            {
                return BadRequest("Invalid index");
            }

            return Ok(CoursePrice[courseIndex]);
        }
    }
}