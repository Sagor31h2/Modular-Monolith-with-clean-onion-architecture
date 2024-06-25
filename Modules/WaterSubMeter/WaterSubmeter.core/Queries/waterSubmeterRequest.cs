using MediatR;
using WaterSubMeter.core.Entity;

namespace WaterSubMeter.core.Queries
{
    public record WaterSubmeterRequest() : IRequest<List<WaterSubmeter>>;

}
