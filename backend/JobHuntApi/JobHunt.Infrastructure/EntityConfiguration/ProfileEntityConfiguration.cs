using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class ProfileEntityConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable("profiles");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired().HasColumnName("name");
        builder.Property(x => x.Lastname).IsRequired().HasColumnName("lastname");
        builder.Property(x => x.Email).IsRequired().HasColumnName("email");
        builder.Property(x => x.Phone).IsRequired().HasColumnName("phone");
        builder.Property(x => x.Avatar).HasColumnName("avatar");
        
       builder
           .HasMany<University>(p => p.Universities)
           .WithOne()
           .HasForeignKey(x => x.ProfileId);
        
       builder
           .HasMany<Experience>( p => p.Experiences)
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
                Avatar = "avatar.jpg",
                DateOfBirth = DateTime.UtcNow,
                AddressId = Guid.Parse("76e24589-638c-4cb9-9970-675a263a7a43"),
           }
       );
    }
}