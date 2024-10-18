using System.Net.Mime;
using System.Reflection;
using JobHunt.Application.Command.Address.CreateAddress;
using JobHunt.Application.Command.Address.DeleteAddress;
using JobHunt.Application.Command.Address.UpdateAddress;
using JobHunt.Application.Command.Experience.CreateExperience;
using JobHunt.Application.Command.Experience.DeleteExperience;
using JobHunt.Application.Command.Experience.UpdateExperience;
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using MassTransit;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using IMediator = MassTransit.Mediator.IMediator;

namespace JobHunt.Application;

public static class ApplicationDependencies
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {


        
        
        
        
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        });
      
        //services.AddScoped<ISendMessage, SendMessage>();

        /*services.AddMassTransit(x =>
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
        });*/
        
        
        
        return services;
    }
}