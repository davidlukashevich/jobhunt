namespace JobHunt.Application.Request;

public class CreateAddressRequest()
{
    public Guid Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
};