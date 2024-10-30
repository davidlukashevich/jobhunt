
using JobHunt.Application.Mapper;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Address.CreateAddress;

public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand>
{
    
    private readonly IAddressRepository _addressRepository;

    public CreateAddressCommandHandler(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

   

    public async Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = AddressMapper.ToAddressModelCreate(request.CreateAddressRequest);
        
        
        await _addressRepository.CreateAddressAsync(address);
        
        
    }
}