using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {   
        services.AddScoped<CowHandlers>();

        return services;
    }
}