using Microsoft.EntityFrameworkCore;

namespace WaterSubMeter.core.Database.Abstract
{
    public interface IWaterSubmeterContext
    {
        public DbSet<Entity.WaterSubmeter> Meters { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
