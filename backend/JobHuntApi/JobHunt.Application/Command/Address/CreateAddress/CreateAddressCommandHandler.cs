
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
        var address = new Domain.Models.Address()
        {
            Id = Guid.NewGuid(),
            Country = request.Country,
            City = request.City,
            Street = request.Street,
        };
        
        await _addressRepository.CreateAddressAsync(address);
    }
}