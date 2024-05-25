using MediatR;
using WaterSubMeter.core.Entity;

namespace WaterSubMeter.core.Queries
{
    public record waterpumpRequest() : IRequest<List<WaterSubmeter>>;

}
