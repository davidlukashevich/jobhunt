using MediatR;

namespace JobHunt.Application.Command.Address.UpdateAddress;

public record UpdateAddressCommand(Guid AddressId,string Country, string City, string Street) : IRequest;