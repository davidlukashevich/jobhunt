namespace JobHunt.Application.MessageBroker;

public interface ISendMessage
{
    Task Send<T>(T message ,CancellationToken cancellationToken) where T : class;
}