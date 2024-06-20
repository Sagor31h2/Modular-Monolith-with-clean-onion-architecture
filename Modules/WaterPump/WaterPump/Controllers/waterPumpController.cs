using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Controllers;
using Shared.Core.Queries;
using WaterPump.Core.Models;
using WaterPump.Core.Queries;

namespace WaterPump.Controllers
{
    [Route("/api/WaterPump/[controller]")]
    internal class WaterPumpController(ISender sender) : BaseController(sender)
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetPums();
            return Ok(await sender.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Create(WaterPumpCreate pumpCreate)
        {
            var query = new WaterPumpCreateRequest(pumpCreate);
            return Ok(await sender.Send(query));
        }
    }
}
