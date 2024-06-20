using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Shared.Controllers
{
    [ApiController]
    public class BaseController(ISender sender) : ControllerBase
    {
        protected readonly ISender sender = sender;
    }
}
