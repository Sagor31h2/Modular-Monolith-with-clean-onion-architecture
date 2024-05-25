using MediatR;
using WaterPump.Core.Database;
using WaterPump.Core.Entity;
using WaterPump.Core.Queries;

namespace WaterPump.Core.Handlers
{
    internal class WaterPumpCreateHandler : IRequestHandler<WaterPumpCreateRequest, int>
    {
        private readonly IWaterPumpContext context;

        public WaterPumpCreateHandler(IWaterPumpContext context)
        {
            this.context = context;
        }
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
