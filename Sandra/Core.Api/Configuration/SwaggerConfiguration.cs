using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Core.Api.Configuration
{
    internal static class SwaggerConfiguration
    {
        private const string Name = "Sandra Core Api";
        private const string VersionString = "v1";
        private const string SwaggerUrl = "/swagger/v1/swagger.json";

        internal static IServiceCollection ConfigureSwagger(this IServiceCollection services) =>
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc(VersionString, new OpenApiInfo { Title = Name, Version = VersionString });
                o.CustomSchemaIds(t => t.FullName);
            });

        internal static IApplicationBuilder UseSwaggerMiddleware(this IApplicationBuilder applicationBuilder) =>
            applicationBuilder
                .UseSwagger()
                .UseSwaggerInterface();

        private static IApplicationBuilder UseSwaggerInterface(this IApplicationBuilder applicationBuilder) =>
            applicationBuilder
                .UseSwaggerUI(o =>
                {
                    o.SwaggerEndpoint(SwaggerUrl, Name);
                    o.RoutePrefix = string.Empty;
                });
    }
}
