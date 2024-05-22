using Microsoft.EntityFrameworkCore;
using Shared.Infrastructure.Persistence;
using System.Diagnostics.Metrics;
using WaterSubMeter.core.DataAccess.Abstract;

namespace WaterSubMeter.core.Database.Concreate
{
    internal class WaterSubmeterContext : ModuleDbContext, IWaterSubmeterContext
    {
        public WaterSubmeterContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meter> Brands { get; set; }

        protected override string Schema => "WaterSubMeter";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
