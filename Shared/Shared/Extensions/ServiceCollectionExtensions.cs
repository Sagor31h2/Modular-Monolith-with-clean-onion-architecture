using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Core.Extensions;
using Shared.Infrastructure.Extensions;

namespace Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharedModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddSharedCore()
                .AddSharedInfrastructure(configuration);
            return services;
        }
    }
}
