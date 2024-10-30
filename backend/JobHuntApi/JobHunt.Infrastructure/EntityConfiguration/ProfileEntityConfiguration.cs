using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class ProfileEntityConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable("profiles");
        
        builder.HasKey(k => k.Id);
        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Name).IsRequired().HasColumnName("name");
        builder.Property(p => p.Lastname).IsRequired().HasColumnName("lastname");
        builder.Property(p => p.Email).IsRequired().HasColumnName("email");
        builder.Property(p => p.Phone).IsRequired().HasColumnName("phone");
        builder.Property(p => p.ProfileImage).HasColumnName("profile_image");
        builder.Property(p => p.AddressId).IsRequired().HasColumnName("address_id");
        builder.Property(p => p.CreatedBy).HasColumnName("createdBy");
        
       
        
       builder
           .HasMany(p => p.Universities)
           .WithOne()
           .HasForeignKey(x => x.ProfileId);

       builder
           .HasMany(p => p.Experiences)
           .WithOne()
           .HasForeignKey(x => x.ProfileId);
           
       
       builder
           .HasOne<Address>( x => x.Address)
           .WithOne()
           .HasForeignKey<Profile>(p => p.AddressId); 
       
       
        
       builder.HasData(

           new Profile()
           {
               Id = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
               Name = "John ",
               Lastname = "Doe",
               Email = "john@doe.com",
               Phone = "123456789",
               DateOfBirth = DateTime.UtcNow,
               AddressId = Guid.Parse("76e24589-638c-4cb9-9970-675a263a7a43"),
               
               CreatedBy = "user"
           }
       );
       
    }
}