using Microsoft.EntityFrameworkCore;
using Shared.Core.Database;
using WaterPump.Core.Entity;

namespace WaterPump.Core.Database
{
    public interface IWaterPumpContext : ISharedDbContext
    {
        public DbSet<WaterPumpInfo> WaterPumpInfos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
