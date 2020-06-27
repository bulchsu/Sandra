using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Api.Configuration
{
    internal static class MediatorConfiguration
    {
        internal static IServiceCollection ConfigureMediator(this IServiceCollection services) =>
            services
                .AddScoped<IMediator, Mediator>()
                .AddTransient<ServiceFactory>(s => 
                    s.GetService);
    }
}
