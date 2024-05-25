using MediatR;
using Microsoft.AspNetCore.Mvc;
using WaterSubMeter.core.Models;
using WaterSubMeter.core.Queries;

namespace WaterSubMeter.Controllers
{
    [ApiController]
    [Route("/api/WaterSubmeter/[controller]")]
    internal class MeterController : ControllerBase
    {

        private readonly IMediator mediatR;

        public MeterController(IMediator mediatR)

        {
            this.mediatR = mediatR;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new waterSubmeterRequest();
            return Ok(await mediatR.Send(query));
            //return Ok(await testService.getall());
        }

        [HttpPost]
        public async Task<IActionResult> Post(WaterSubmeterCreateModel waterSubmeter)
        {
            var query = new WaterSubmeterCommand(waterSubmeter);
            return Ok(await mediatR.Send(query));
        }
    }
}
