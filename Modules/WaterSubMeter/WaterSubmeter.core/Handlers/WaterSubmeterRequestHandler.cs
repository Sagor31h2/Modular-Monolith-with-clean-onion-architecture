using MediatR;
using Microsoft.EntityFrameworkCore;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Queries;

namespace WaterSubMeter.core.Handlers
{
    internal class WaterSubmeterRequestHandler(IWaterSubmeterContext context) : IRequestHandler<waterSubmeterRequest, List<WaterSubmeter>>
    {
        async Task<List<WaterSubmeter>> IRequestHandler<waterSubmeterRequest, List<WaterSubmeter>>.Handle(waterSubmeterRequest request, CancellationToken cancellationToken)
        {
            var list = await context.Meters.ToListAsync();
            return list;
        }
    }
}
