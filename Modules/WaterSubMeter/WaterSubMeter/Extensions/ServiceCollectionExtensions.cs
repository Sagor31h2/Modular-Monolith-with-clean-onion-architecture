using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WaterSubMeter.core.Extensions;
using WaterSubMeter.Infrastructure.Extensions;

namespace WaterSubMeter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWaterSubmeterModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddWaterSubMeterCore()
                .AddWaterSubmeterInfrastructure(configuration);
            return services;
        }
    }
}
