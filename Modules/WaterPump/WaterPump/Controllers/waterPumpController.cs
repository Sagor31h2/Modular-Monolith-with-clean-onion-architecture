using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Controllers;
using WaterPump.Core.Models;
using WaterPump.Core.Queries;

namespace WaterPump.Controllers
{

    [Route("/api/WaterPump/[controller]")]
    internal class WaterPumpController : BaseController
    {
        private readonly ISender sender;

        public WaterPumpController(ISender sender) : base(sender)
        {
            this.sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetPums();
            return Ok(await sender.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> create(WaterPumpCreate pumpCreate)
        {
            var query = new WaterPumpCreateRequest(pumpCreate);
            return Ok(await sender.Send(query));
        }
    }
}
