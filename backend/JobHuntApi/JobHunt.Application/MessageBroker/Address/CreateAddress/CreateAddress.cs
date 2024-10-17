namespace JobHunt.Application.MessageBroker.Address.CreateAddress;

public class CreateAddress
{
    public Guid Id  { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
}