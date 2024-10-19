
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.MessageBroker.Address.DeleteAddress;
using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;


namespace JobHunt.Application;

public static class ApplicationDependencies
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        });
      
        services.AddScoped<ISendMessage, SendMessage>();

        services.AddMassTransit(x =>
        {
            
            x.AddConsumer<CreateAddressConsumer>();
            x.AddConsumer<UpdateAddressConsumer>();
            x.AddConsumer<DeleteAddressConsumer>();
            
            x.UsingRabbitMq((ctx, cfg) =>
            {
                cfg.Host("rabbitmq://localhost", o =>
                {
                    o.Username("guest");
                    o.Password("guest");
                });
                
                cfg.ReceiveEndpoint("create-address", e =>
                {
                    e.ConfigureConsumer<CreateAddressConsumer>(ctx);
                });
                
                cfg.ReceiveEndpoint("update-address", e =>
                {
                    e.ConfigureConsumer<UpdateAddressConsumer>(ctx);
                });
                
                cfg.ReceiveEndpoint("delete-address", e =>
                {
                    e.ConfigureConsumer<DeleteAddressConsumer>(ctx);
                });
            });
        });
        
        
        
        return services;
    }
}