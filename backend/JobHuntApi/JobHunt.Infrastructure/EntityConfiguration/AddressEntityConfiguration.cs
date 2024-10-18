using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Country).IsRequired().HasColumnName("country");
        builder.Property(x => x.City).IsRequired().HasColumnName("city");
        builder.Property(x => x.Street).IsRequired().HasColumnName("street");
        
        builder.HasData(

            new Address()
            {
                Id = Guid.Parse("76e24589-638c-4cb9-9970-675a263a7a43"),
                Country = "USA ",
                City = "New York",
                Street = "street address 1",
                
            }
        );
    }
}