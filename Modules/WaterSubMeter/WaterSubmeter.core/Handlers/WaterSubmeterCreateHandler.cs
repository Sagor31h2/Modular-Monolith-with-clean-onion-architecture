using MediatR;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;
using WaterSubMeter.core.Queries;

namespace WaterSubMeter.core.Handlers
{
    internal class WaterSubmeterCreateHandler : IRequestHandler<WaterSubmeterCommand, int>
    {
        private readonly IWaterSubmeterContext waterSubmeterContext;

        public WaterSubmeterCreateHandler(IWaterSubmeterContext waterSubmeterContext)
        {
            this.waterSubmeterContext = waterSubmeterContext;
        }
        async Task<int> IRequestHandler<WaterSubmeterCommand, int>.Handle(WaterSubmeterCommand request, CancellationToken cancellationToken)
        {
            var waterSubmeter = new WaterSubmeter
            {
                Name = request.CreateModel.Name,
                Detail = request.CreateModel.Detail,
            };
            await waterSubmeterContext.Meters.AddAsync(waterSubmeter);
            await waterSubmeterContext.SaveChangesAsync();

            return waterSubmeter.Id;
        }
    }
}
