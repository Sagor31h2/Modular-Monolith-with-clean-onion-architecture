using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPump.Core.Models;

namespace WaterPump.Core.Queries
{
    public record WaterPumpCreateRequest(WaterPumpCreate model):IRequest<int>;
    
}
