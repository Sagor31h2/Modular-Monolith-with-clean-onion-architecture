using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Controllers
{
    [ApiController]
    public class BaseController: ControllerBase
    {
        private readonly ISender sender;

        public BaseController(ISender sender)
        {
            this.sender = sender;
        }
    }
}
