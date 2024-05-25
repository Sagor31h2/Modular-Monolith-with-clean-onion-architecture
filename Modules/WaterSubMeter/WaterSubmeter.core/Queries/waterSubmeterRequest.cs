using MediatR;
using WaterSubMeter.core.Entity;

namespace WaterSubMeter.core.Queries
{
    public record waterSubmeterRequest() : IRequest<List<WaterSubmeter>>;

}
