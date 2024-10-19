using MassTransit;

namespace JobHunt.Application.MessageBroker;

public class SendMessage : ISendMessage
{
    
    private readonly IPublishEndpoint _publisher;

    public SendMessage(IPublishEndpoint publisher)
    {
        _publisher = publisher;
    }

    public async Task Send<T>(T message, CancellationToken cancellationToken) where T : class
    {
        await _publisher.Publish<T>(message!, cancellationToken);
    }
}