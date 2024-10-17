using JobHunt.Domain.Interface.Repository;
using MediatR;


namespace JobHunt.Application.Command.Address.DeleteAddress;

public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
{
    private readonly IAddressRepository _addressRepository;

    public DeleteAddressCommandHandler(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
    {
        await _addressRepository.DeleteAddressAsync(request.AddressId);
    }
}