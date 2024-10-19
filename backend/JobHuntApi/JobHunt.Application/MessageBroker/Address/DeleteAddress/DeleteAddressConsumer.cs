using JobHunt.Application.Command.Address.DeleteAddress;
using MassTransit;
using MediatR;

namespace JobHunt.Application.MessageBroker.Address.DeleteAddress;

public class DeleteAddressConsumer : IConsumer<DeleteAddress>
{
    
    private readonly ISender _sender;

    public DeleteAddressConsumer(ISender sender)
    {
        _sender = sender;
    }

    public async Task Consume(ConsumeContext<DeleteAddress> context)
    {
        await _sender.Send(new DeleteAddressCommand(context.Message.AddressId));
    }
}