using JobHunt.Application.Request.Address;
using MediatR;

namespace JobHunt.Application.Command.Address.UpdateAddress;

public record UpdateAddressCommand(Guid AddressId, UpdateAddressRequest UpdateAddressRequest) : IRequest;