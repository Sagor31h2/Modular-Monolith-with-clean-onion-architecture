using MediatR;
using Microsoft.AspNetCore.Mvc;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Queries;
using WaterSubMeter.core.Service;

namespace WaterSubMeter.Controllers
{
    [ApiController]
    [Route("/api/WaterSubmeter/[controller]")]
    internal class MeterController : ControllerBase
    {
        private readonly TestService testService;
        private readonly IWaterSubmeterContext waterSubmeter;
        private readonly IMediator mediatR;

        public MeterController(IWaterSubmeterContext waterSubmeter, IMediator mediatR)
        
        {
            this.testService = new TestService(waterSubmeter);
            this.waterSubmeter = waterSubmeter;
            this.mediatR = mediatR;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new waterpumpRequest();
            return Ok(await mediatR.Send(query));
            //return Ok(await testService.getall());
        }

        [HttpPost]
        public async Task<IActionResult> Post(WaterSubmeter waterSubmeter)
        {
            return Ok(await testService.create(waterSubmeter));
        }
    }
}
