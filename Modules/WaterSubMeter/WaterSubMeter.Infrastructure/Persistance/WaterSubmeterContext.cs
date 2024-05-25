using Microsoft.EntityFrameworkCore;
using Shared.Infrastructure.Persistence;
using WaterSubMeter.core.Database.Abstract;


namespace WaterSubMeter.Infrastructure.Persistance
{
    internal class WaterSubmeterContext : SharedDbContext, IWaterSubmeterContext
    {
        public WaterSubmeterContext(DbContextOptions<WaterSubmeterContext> options) : base(options)
        {
        }

        public DbSet<core.Entity.WaterSubmeter> Meters { get; set; }

        protected override string Schema => "WaterSubMeter";
    }
}
