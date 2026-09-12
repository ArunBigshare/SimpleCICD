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
                message = "Welcome to CI/CD Pipeline Updated Version 2.0!",
                timestamp = DateTime.UtcNow,
                status = "success"
            });
        }
    }
}
