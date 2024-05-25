using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Models;

namespace WaterSubMeter.core.Queries
{
    public record WaterSubmeterCommand(WaterSubmeterCreateModel CreateModel):IRequest<int>;
  
}
