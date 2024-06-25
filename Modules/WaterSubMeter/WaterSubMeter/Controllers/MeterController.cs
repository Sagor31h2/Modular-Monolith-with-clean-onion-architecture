using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Controllers;
using WaterSubMeter.core.Models;
using WaterSubMeter.core.Queries;

namespace WaterSubMeter.Controllers
{
    [Route("/api/WaterSubmeter/[controller]")]
    internal class MeterController(ISender sender) : BaseController(sender)
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new WaterSubmeterRequest();
            return Ok(await sender.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(WaterSubmeterCreateModel waterSubmeter)
        {
            var query = new WaterSubmeterCommand(waterSubmeter);
            return Ok(await sender.Send(query));
        }
    }
}
