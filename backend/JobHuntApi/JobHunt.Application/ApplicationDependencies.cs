using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using MassTransit;
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

        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((ctx, cfg) =>
            {
                cfg.Host("rabbitmq://localhost", o =>
                {
                    o.Username("guest");
                    o.Password("guest");
                });
                
                cfg.ReceiveEndpoint("create-address", e =>
                {
                    e.Consumer<CreateAddressConsumer>(ctx);
                });
                
                cfg.ReceiveEndpoint("update-address", e =>
                {
                    e.Consumer<UpdateAddressConsumer>(ctx);
                });
            });
        });
        
        
        
        return services;
    }
}