using MediatR;

namespace JobHunt.Application.Command.Address.DeleteAddress;

public record DeleteAddressCommand(Guid AddressId) : IRequest;