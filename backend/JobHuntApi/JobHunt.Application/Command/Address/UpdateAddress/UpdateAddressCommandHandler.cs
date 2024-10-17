using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Address.UpdateAddress;

public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
{
    
    private readonly IAddressRepository _addressRepository;

    public UpdateAddressCommandHandler(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {

        var updatedAddress = new Domain.Models.Address
        {
            Country = request.Country,
            City = request.City,
            Street = request.Street,
        };
        
        await _addressRepository.UpdateAddressAsync( updatedAddress, request.AddressId);
    }
}