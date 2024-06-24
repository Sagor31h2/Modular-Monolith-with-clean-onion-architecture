using MediatR;
using WaterPump.Core.Database;
using WaterPump.Core.Entity;
using WaterPump.Core.Queries;

namespace WaterPump.Core.Handlers
{
    internal class WaterPumpCreateHandler(IWaterPumpContext context) : IRequestHandler<WaterPumpCreateRequest, int>
    {
        public async Task<int> Handle(WaterPumpCreateRequest request, CancellationToken cancellationToken)
        {
            var pump = new WaterPumpInfo
            {
                LocationId = request.model.LocationId,
                PumpType = request.model.PumpType,
                WaterPumpNo = request.model.WaterPumpNo
            };
            await context.WaterPumpInfos.AddAsync(pump);
            await context.SaveChangesAsync(cancellationToken);

            return pump.Id;
        }
    }
}
