using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses");
        
        builder.HasKey(k => k.Id);

        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Country).IsRequired().HasColumnName("country");
        builder.Property(p => p.City).IsRequired().HasColumnName("city");
        builder.Property(p => p.Street).IsRequired().HasColumnName("street");
        builder.Property(p => p.CreatedAt).HasColumnName("createdAt");
        builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt");
        
        
        /*builder.HasData(

            new Address()
            {
                Id = Guid.Parse("76e24589-638c-4cb9-9970-675a263a7a43"),
                Country = "USA ",
                City = "New York",
                Street = "street address 1",
                
            }
        );*/
    }
}