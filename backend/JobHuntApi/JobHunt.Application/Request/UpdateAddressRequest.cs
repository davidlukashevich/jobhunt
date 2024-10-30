namespace JobHunt.Application.Request;

public class UpdateAddressRequest
{
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
}