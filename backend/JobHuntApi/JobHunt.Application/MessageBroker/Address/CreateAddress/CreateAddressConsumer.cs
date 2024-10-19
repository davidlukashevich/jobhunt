
using JobHunt.Application.Command.Address.CreateAddress;
using JobHunt.Application.Request;
using MassTransit;
using MediatR;

namespace JobHunt.Application.MessageBroker.Address.CreateAddress;

public class CreateAddressConsumer : IConsumer<CreateAddress>
{
    
    private readonly ISender _sender;

    public CreateAddressConsumer(ISender sender)
    {
        _sender = sender;
    }

    public async Task Consume(ConsumeContext<CreateAddress> context)
    {
        var createAddressRequest = new CreateAddressRequest()
        {
            Id = context.Message.Id,
            Country = context.Message.Country!,
            City = context.Message.City!,
            Street= context.Message.Street!,
        };
        
        await _sender.Send(new CreateAddressCommand(createAddressRequest));
    }
}