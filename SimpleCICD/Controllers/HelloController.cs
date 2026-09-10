using Microsoft.AspNetCore.Mvc;

namespace SimpleCICD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                message = "Hello from CI test!",
                timestamp = DateTime.UtcNow,
                status = "success"
            });
        }
    }
}
