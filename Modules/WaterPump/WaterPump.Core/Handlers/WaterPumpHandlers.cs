using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Core.Models.WaterPump;
using WaterPump.Core.Database;
using WaterPump.Core.Queries;

namespace WaterPump.Core.Handlers
{
    internal class WaterPumpHandlers : IRequestHandler<GetPums, List<WaterPumps>>
    {
        private readonly IWaterPumpContext context;

        public WaterPumpHandlers(IWaterPumpContext context)
        {
            this.context = context;
        }
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
