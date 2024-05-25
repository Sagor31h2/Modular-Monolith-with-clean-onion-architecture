using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.Extensions;
using WaterPump.Core.Database;
using WaterPump.Ifrastructure.Persistance;


namespace WaterPump.Ifrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWaterPumpInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<WaterPumpContext>(config)
                .AddScoped<IWaterPumpContext>(provider => provider.GetService<WaterPumpContext>());
            return services;
        }
    }
}
