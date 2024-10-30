using JobHunt.Application.Mapper;
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

        var updateAddressRequest = request.UpdateAddressRequest;

        var updatedAddress = AddressMapper.ToAddressModelUpdate(updateAddressRequest);
       
        
        await _addressRepository.UpdateAddressAsync( updatedAddress, request.AddressId);
    }
}