using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class JobEntityConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.ToTable("jobs");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Title).HasColumnName("title").IsRequired();
        builder.Property(x => x.CompanyName).HasColumnName("company_name").IsRequired();
        builder.Property(x => x.ContractType).HasColumnName("contract_type").IsRequired();
        builder.Property(x => x.JobLevel).HasColumnName("job_level").IsRequired();
        builder.Property(x => x.Responsibilities).HasColumnName("responsibilities").IsRequired();
        builder.Property(x => x.Requirements).HasColumnName("requirements").IsRequired();
        builder.Property(x => x.AddressId).HasColumnName("address_id").IsRequired();
        builder.Property(x => x.OperationMode).HasColumnName("operation_mode").IsRequired();
        
        builder
            .HasOne<Address>(j => j.Address)
            .WithOne()
            .HasForeignKey<Job>(j => j.AddressId);
        
    }
}