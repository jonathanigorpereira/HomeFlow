using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace HomeFlowApi.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "HomeFlow API",
                Version = "v1",
                Description = "API de gestão de compras domésticas."
            });
        });
        services.AddOpenApi();

        return services;
    }
}
