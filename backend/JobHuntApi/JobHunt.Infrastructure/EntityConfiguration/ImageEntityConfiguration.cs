using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class ImageEntityConfiguration : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.ToTable("images");
        builder.HasKey(k => k.Id);
        
        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Name).HasColumnName("name").IsRequired();
        builder.Property(p => p.ImageUrl).HasColumnName("image_url").IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("createdAt");
        builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt");
        
        
    }
}