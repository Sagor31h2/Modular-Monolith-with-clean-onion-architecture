using MediatR;
using Shared.Core.Models.WaterPump;

namespace Shared.Core.Queries
{
    public record class GetPums : IRequest<List<WaterPumps>>;

}
