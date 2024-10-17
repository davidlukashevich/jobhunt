namespace JobHunt.Application.MessageBroker.Address.UpdateAddress;

public class UpdateAddress
{
    public Guid Id  { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
}