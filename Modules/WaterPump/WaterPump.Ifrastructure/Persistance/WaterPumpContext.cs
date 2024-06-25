using Microsoft.EntityFrameworkCore;
using Shared.Infrastructure.Persistance;
using WaterPump.Core.Database;
using WaterPump.Core.Entity;

namespace WaterPump.Ifrastructure.Persistance
{
    internal class WaterPumpContext : SharedDbContext, IWaterPumpContext
    {
        public WaterPumpContext(DbContextOptions options) : base(options)
        {
        }
        protected override string Schema => "waterPump";

        public DbSet<WaterPumpInfo> WaterPumpInfos { get; set; }

        
    }
}
