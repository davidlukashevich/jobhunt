
using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class JobEntityConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.ToTable("jobs");
        
        builder.HasKey(k => k.Id);

        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Title).HasColumnName("title").IsRequired();
        builder.Property(p => p.CompanyName).HasColumnName("company_name").IsRequired();
        builder.Property(p => p.ContractType).HasColumnName("contract_type").IsRequired();
        builder.Property(p => p.JobLevel).HasColumnName("job_level").IsRequired();
        builder.Property(p => p.Responsibilities).HasColumnName("responsibilities").IsRequired();
        builder.Property(p => p.Requirements).HasColumnName("requirements").IsRequired();
        builder.Property(p => p.AddressId).HasColumnName("address_id").IsRequired();
        builder.Property(p => p.OperationMode).HasColumnName("operation_mode").IsRequired();
        builder.Property(p => p.Type).HasColumnName("type").IsRequired();
        builder.Property(p => p.Technology).HasColumnName("technology").IsRequired();
        builder.Property(p => p.CreatedBy).HasColumnName("created_by").IsRequired();
        builder.Property(p => p.ImageId).HasColumnName("image_id");
        builder.Property(p => p.CreatedAt).HasColumnName("createdAt");
        builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt");
        builder.Property(p => p.AboutCompany).HasColumnName("about_company").IsRequired();
        

        builder
            .HasIndex(j =>  new {  j.Title, j.JobLevel, j.Technology, j.Type })
            .HasMethod("GIN")
            .IsTsVectorExpressionIndex("english");


        builder
            .HasOne<Address>(j => j.Address)
            .WithOne()
            .HasForeignKey<Job>(j => j.AddressId);
            
        

        builder
            .HasOne<Image>(j => j.Image)
            .WithOne()
            .HasForeignKey<Job>(j => j.ImageId);

        builder
            .HasMany(j => j.JobApplications)
            .WithOne()
            .HasForeignKey(j => j.JobId);

    }
}