using JobHunt.Application.DTO;
using JobHunt.Application.Request;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class AddressMapper
{
   public static AddressDTO ToAddressDto(this Address address)
   {
      return new AddressDTO()
      {
         Id = address.Id,
         City = address.City,
         Country = address.Country,
         Street = address.Street,
      };
   }

   public static Address ToAddressModelCreate(CreateAddressRequest addressRequest)
   {
      return new Address()
      {
         Id = addressRequest.Id,
         City = addressRequest.City,
         Country = addressRequest.Country,
         Street = addressRequest.Street,
      };
   }
   
   public static Address ToAddressModelUpdate(UpdateAddressRequest addressRequest)
   {
      return new Address()
      {
         City = addressRequest.City,
         Country = addressRequest.Country,
         Street = addressRequest.Street,
      };
   }

   public static CreateAddressRequest ToCreateAddressRequest(string city, string country, string street)
   {
      return new CreateAddressRequest()
      {
         Id = Guid.NewGuid(),
         City = city,
         Country = country,
         Street = street,
      };
   }

   public static UpdateAddressRequest ToUpdateAddressRequest(string city, string country, string street)
   {
      return new UpdateAddressRequest()
      {
         City = city,
         Country = country,
         Street = street,
      };
   }

   
}