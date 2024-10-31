using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class JobApplicationEntityConfiguration : IEntityTypeConfiguration<JobApplication>
{
    public void Configure(EntityTypeBuilder<JobApplication> builder)
    {
        builder.ToTable("job_applications");
        builder.HasKey(k => k.Id);
        
        
        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Name).HasColumnName("name").IsRequired();
        builder.Property(p => p.LastName).HasColumnName("lastname").IsRequired();
        builder.Property(p => p.CreatedBy).HasColumnName("createdBy").IsRequired();
        builder.Property(p => p.Email).HasColumnName("email").IsRequired();
        builder.Property(p => p.Phone).HasColumnName("phone");
        builder.Property(p => p.AboutInformation).HasColumnName("about_information");
        builder.Property(p => p.Cv).HasColumnName("cv");
        builder.Property(p => p.JobId).HasColumnName("job_id");
        builder.Property(p => p.CreatedAt).HasColumnName("createdAt");
        builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt");
    }
}