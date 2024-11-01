
using JobHunt.Application.Request.Address;
using MediatR;

namespace JobHunt.Application.Command.Address.CreateAddress;

public record CreateAddressCommand(CreateAddressRequest CreateAddressRequest) : IRequest;