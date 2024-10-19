using JobHunt.Application.Command.Address.UpdateAddress;

using MassTransit;
using MediatR;

namespace JobHunt.Application.MessageBroker.Address.UpdateAddress;

public class UpdateAddressConsumer : IConsumer<UpdateAddress>
{
    private readonly ISender _sender;

    public UpdateAddressConsumer(ISender sender)
    {
        _sender = sender;
    }

    public async Task Consume(ConsumeContext<UpdateAddress> context)
    {

        var data = context.Message;

        await _sender.Send(new UpdateAddressCommand(data.Id, data.Country!, data.City!, data.Street! ));





    }
}