using Microsoft.Extensions.DependencyInjection;

namespace JobHunt.Application;

public static class ApplicationDependencies
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        });
        
        return services;
    }
}