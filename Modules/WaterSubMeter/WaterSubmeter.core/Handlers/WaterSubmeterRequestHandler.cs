using MediatR;
using Microsoft.EntityFrameworkCore;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Queries;

namespace WaterSubMeter.core.Handlers
{
    internal class WaterSubmeterRequestHandler : IRequestHandler<waterpumpRequest, List<WaterSubmeter>>
    {
        private readonly IWaterSubmeterContext context;

        public WaterSubmeterRequestHandler(IWaterSubmeterContext context)
        {
            this.context = context;
        }

        async Task<List<WaterSubmeter>> IRequestHandler<waterpumpRequest, List<WaterSubmeter>>.Handle(waterpumpRequest request, CancellationToken cancellationToken)
        {
            var list = await context.Meters.ToListAsync();
            return list;
        }
    }
}
