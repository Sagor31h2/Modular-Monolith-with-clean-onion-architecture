using Microsoft.EntityFrameworkCore;
using Shared.Core.Database;

namespace WaterSubMeter.core.Database.Abstract
{
    public interface IWaterSubmeterContext : ISharedDbContext
    {
        public DbSet<Entity.WaterSubmeter> Meters { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
