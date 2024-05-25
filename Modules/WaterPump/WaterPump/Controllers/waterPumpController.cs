using MediatR;
using Microsoft.AspNetCore.Mvc;
using WaterPump.Core.Models;
using WaterPump.Core.Queries;

namespace WaterPump.Controllers
{
    [ApiController]
    [Route("/api/WaterPump/[controller]")]
    internal class WaterPumpController : ControllerBase
    {
        private readonly IMediator mediator;

        public WaterPumpController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetPums();
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> create(WaterPumpCreate pumpCreate)
        {
            var query = new WaterPumpCreateRequest(pumpCreate);
            return Ok(await mediator.Send(query));
        }
    }
}
