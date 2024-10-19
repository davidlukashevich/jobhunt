using JobHunt.Application.DTO;

namespace JobHunt.Application.Mapper;

public static class AddressMapper
{
   public static AddressDTO ToAddressDto(this Domain.Models.Address address)
   {
      return new AddressDTO()
      {
         Id = address.Id,
         City = address.City,
         Country = address.Country,
         Street = address.Street,
      };
   }
}