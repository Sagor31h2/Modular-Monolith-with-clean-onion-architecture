using MediatR;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Queries;

namespace WaterSubMeter.core.Handlers
{
    internal class WaterSubmeterCreateHandler(IWaterSubmeterContext coontext) : IRequestHandler<WaterSubmeterCommand, int>
    {
        async Task<int> IRequestHandler<WaterSubmeterCommand, int>.Handle(WaterSubmeterCommand request, CancellationToken cancellationToken)
        {
            var waterSubmeter = new WaterSubmeter
            {
                Name = request.CreateModel.Name,
                Detail = request.CreateModel.Detail,
            };
            await coontext.Meters.AddAsync(waterSubmeter);
            await coontext.SaveChangesAsync();

            return waterSubmeter.Id;
        }
    }
}
