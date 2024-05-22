using Microsoft.AspNetCore.Mvc;

namespace WaterSubMeter.Controllers
{
    [ApiController]
    [Route("/api/catalog/[controller]")]
    internal class MeterController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello World!");
        }
    }
}
