using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.Extensions;
using WaterSubMeter.core.Database.Abstract;
using WaterSubMeter.Infrastructure.Persistance;

namespace WaterSubMeter.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWaterSubmeterInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<WaterSubmeterContext>(config)
                .AddScoped<IWaterSubmeterContext>(provider => provider.GetService<WaterSubmeterContext>());
            return services;
        }
    }
}
