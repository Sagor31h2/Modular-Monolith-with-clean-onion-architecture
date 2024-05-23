using Microsoft.AspNetCore.Mvc;

namespace WaterPump.Controllers
{
    [ApiController]
    [Route("/api/WaterPump/[controller]")]
    internal class WaterPumpController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
