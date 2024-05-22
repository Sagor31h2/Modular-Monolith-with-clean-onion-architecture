using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WaterSubMeter.core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWaterSubMeterCore(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
