
using MediatR;

namespace JobHunt.Application.Command.Address.CreateAddress;

public record CreateAddressCommand(string Country, string City, string Street ) : IRequest;