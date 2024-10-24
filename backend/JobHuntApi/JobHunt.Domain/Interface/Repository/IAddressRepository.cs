using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IAddressRepository
{
    Task CreateAddressAsync(Address address);
    Task<bool> DeleteAddressAsync(Guid addressId);
    Task<bool> UpdateAddressAsync(Address address, Guid adressId);
}