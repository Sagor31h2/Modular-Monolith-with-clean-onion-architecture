using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Core.Models.WaterPump;
using Shared.Core.Queries;
using WaterPump.Core.Database;

namespace WaterPump.Core.Handlers
{
    internal class WaterPumpHandlers(IWaterPumpContext context) : IRequestHandler<GetPums, List<WaterPumps>>
    {
        public async Task<List<WaterPumps>> Handle(GetPums request, CancellationToken cancellationToken)
        {
            return await context.WaterPumpInfos.Select(x => new WaterPumps
            {
                Id = x.Id,
                WaterPumpNo = x.WaterPumpNo,
                LocationId = x.LocationId,
                PumpType = x.PumpType,
            }).ToListAsync();
        }
    }
}
