using JobHunt.Domain.Interface.Repository;
using MassTransit;

namespace JobHunt.Application.MessageBroker.Address.CreateAddress;

public class CreateAddressConsumer : IConsumer<CreateAddress>
{
    
    private readonly IAddressRepository _addressRepository;

    public CreateAddressConsumer(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task Consume(ConsumeContext<CreateAddress> context)
    {
        var address = new Domain.Models.Address()
        {
            Id = context.Message.Id,
            Country = context.Message.Country,
            City = context.Message.City,
            Street = context.Message.Street,
        };
        
        await _addressRepository.CreateAddressAsync(address);
    }
}