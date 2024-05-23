using Microsoft.EntityFrameworkCore;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.core.Entity;

namespace WaterSubMeter.core.Service
{
    public class TestService
    {
        private readonly IWaterSubmeterContext context;

        public TestService(IWaterSubmeterContext context)
        {
            this.context = context;
        }

        public async Task<int> create(WaterSubmeter model)
        {
            await context.Meters.AddAsync(model);
            return await context.SaveChangesAsync();
        }

        public async Task<List<WaterSubmeter>> getall()
        {
            return await context.Meters.ToListAsync();
        }
    }
}
