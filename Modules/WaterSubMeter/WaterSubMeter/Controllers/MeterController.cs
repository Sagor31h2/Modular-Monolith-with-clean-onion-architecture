using Microsoft.AspNetCore.Mvc;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Service;

namespace WaterSubMeter.Controllers
{
    [ApiController]
    [Route("/api/WaterSubmeter/[controller]")]
    internal class MeterController : ControllerBase
    {
        private readonly TestService testService;
        private readonly IWaterSubmeterContext waterSubmeter;

        public MeterController(IWaterSubmeterContext waterSubmeter)
        {
            this.testService = new TestService(waterSubmeter);
            this.waterSubmeter = waterSubmeter;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await testService.getall());
        }

        [HttpPost]
        public async Task<IActionResult> Post(WaterSubmeter waterSubmeter)
        {
            return Ok(await testService.create(waterSubmeter));
        }
    }
}
