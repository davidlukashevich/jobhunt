using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IAdressRepository
{
    Task CreateAddressAsync(Address address);
    Task DeleteAddressAsync(Guid addressId);
    Task UpdateAddressAsync(Address address, Guid adressId);
}