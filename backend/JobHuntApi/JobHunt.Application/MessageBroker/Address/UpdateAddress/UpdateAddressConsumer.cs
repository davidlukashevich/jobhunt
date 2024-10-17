using JobHunt.Domain.Interface.Repository;
using MassTransit;

namespace JobHunt.Application.MessageBroker.Address.UpdateAddress;

public class UpdateAddressConsumer : IConsumer<UpdateAddress>
{
    private readonly IAddressRepository _addressRepository;

    public UpdateAddressConsumer(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task Consume(ConsumeContext<UpdateAddress> context)
    {

        var updatedAddress = new Domain.Models.Address()
        {
            City = context.Message.City,
            Country = context.Message.Country,
            Street = context.Message.Street,
        };
        
        await _addressRepository.UpdateAddressAsync(updatedAddress, context.Message.Id);
    }
}