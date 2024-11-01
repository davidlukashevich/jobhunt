namespace JobHunt.Application.Request.Address;

public class UpdateAddressRequest
{
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
}