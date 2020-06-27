using Microsoft.Extensions.DependencyInjection;

namespace Core.Api.Configuration
{
    internal static class ControllersConfiguration
    {
        internal static IServiceCollection ConfigureControllers(this IServiceCollection services) =>
            services
                .AddControllers()
                .AddNewtonsoftJson()
                .Services;
    }
}
