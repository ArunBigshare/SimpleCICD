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
                message = "Hello from CI/CD Version 2 Testing!",
                timestamp = DateTime.UtcNow,
                status = "success"
            });
        }
    }
}
