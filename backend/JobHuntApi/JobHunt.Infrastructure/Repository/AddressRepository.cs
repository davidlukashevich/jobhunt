using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Repository;

public class AddressRepository : IAddressRepository
{
    
    private readonly JobHuntDbContext _context;

    public AddressRepository(JobHuntDbContext context)
    {
        _context = context;
    }

    public async Task CreateAddressAsync(Address address)
    {
        await _context.Addresses.AddAsync(address);
        
        await _context.SaveChangesAsync();
    }

    public async Task<bool> DeleteAddressAsync(Guid addressId)
    {
        var deleteResult = await _context.Addresses
            .Where(a => a.Id == addressId)
            .ExecuteDeleteAsync();

        return deleteResult > 0;
    }

    public async Task<bool> UpdateAddressAsync(Address address, Guid adressId)
    {
        var updateResult = await _context.Addresses
            .Where(a => a.Id == adressId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Country, address.Country)
                .SetProperty(p => p.City, address.City)
                .SetProperty(p => p.Street, address.Street)
            );
        
        return updateResult > 0;
    }
}