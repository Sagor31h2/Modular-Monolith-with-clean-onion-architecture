using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WaterPump.Core.Extenstions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWaterPumpCore(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
