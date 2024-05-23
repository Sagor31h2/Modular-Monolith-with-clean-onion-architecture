using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSubMeter.core.Entity;

namespace WaterSubMeter.core.Queries
{
    public record waterpumpRequest() : IRequest<List<WaterSubmeter>>;

}
