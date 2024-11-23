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
        builder.Property(p => p.AddressId).IsRequired().HasColumnName("address_id");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.ImageId).HasColumnName("image_id");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.Specialization).HasColumnName("specialization").IsRequired();
        builder.Property(p => p.ProfileSummary).HasColumnName("profile_summary").IsRequired();
        
       
        
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
       
       
       builder
           .HasOne<Image>( x => x.Image )
           .WithOne()
           .HasForeignKey<Profile>(p => p.ImageId);
       
       
       
       
    }
}