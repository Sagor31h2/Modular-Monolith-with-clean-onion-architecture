using Microsoft.EntityFrameworkCore;
using Shared.Infrastructure.Persistence;
using WaterPump.Core.Database;
using WaterPump.Core.Entity;

namespace WaterPump.Ifrastructure.Persistance
{
    internal class WaterPumpContext : SharedDbContext, IWaterPumpContext
    {
        public WaterPumpContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WaterPumpInfo> WaterPumpInfos { get; set; }

        protected override string Schema => "waterPump";
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
