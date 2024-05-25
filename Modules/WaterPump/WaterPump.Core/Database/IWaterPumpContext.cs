using Microsoft.EntityFrameworkCore;
using WaterPump.Core.Entity;

namespace WaterPump.Core.Database
{
    public interface IWaterPumpContext
    {
        public DbSet<WaterPumpInfo> WaterPumpInfos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
