using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WaterPump.Core.Extenstions;
using WaterPump.Ifrastructure.Extensions;

namespace WaterSubMeter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWaterPumpModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddWaterPumpCore()
                .AddWaterPumpInfrastructure(configuration);
            return services;
        }
    }
}
