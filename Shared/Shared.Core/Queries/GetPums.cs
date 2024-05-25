using MediatR;
using Shared.Core.Models.WaterPump;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterPump.Core.Queries
{
    public record class GetPums:IRequest<List<WaterPumps>>;
    
}
