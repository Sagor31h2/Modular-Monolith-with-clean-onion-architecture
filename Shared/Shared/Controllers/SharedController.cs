using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Core.Queries;

namespace Shared.Controllers
{
    [Route("/api/Shared/[controller]")]
    internal class SharedController(ISender sender) : BaseController(sender)
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetPums();
            return Ok(await sender.Send(query));
        }

    }
}
