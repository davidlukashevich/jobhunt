using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class ExperienceEntityConfiguration : IEntityTypeConfiguration<Experience>
{
    public void Configure(EntityTypeBuilder<Experience> builder)
    {
        builder.ToTable("experiences");
        builder.HasKey(x => x.Id);
        
        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Position).HasColumnName("position").IsRequired();
        builder.Property(p => p.CompanyName).HasColumnName("company_name").IsRequired();
        builder.Property(p => p.Responsibility).HasColumnName("responsibility").IsRequired();
        builder.Property(p => p.Location).HasColumnName("location").IsRequired();
        builder.Property(p => p.WorkFrom).HasColumnName("work_from").IsRequired();
        builder.Property(p => p.WorkTo).HasColumnName("work_to").IsRequired();
        builder.Property(p => p.ProfileId).HasColumnName("user_id");

        builder.HasData(new List<Experience>()
        {
            new Experience()
            {
                Id = Guid.NewGuid(),
                Position = "Position",
                CompanyName = "CompanyName",
                Responsibility = "Responsibility",
                Location = "Location",
                ProfileId = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                WorkFrom = DateTime.UtcNow,
                WorkTo = DateTime.UtcNow,
                
            },
            new Experience()
            {
                Id = Guid.NewGuid(),
                Position = "Position 2",
                CompanyName = "CompanyName 2",
                Responsibility = "Responsibility 2",
                Location = "Location 2",
                ProfileId = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                WorkFrom = DateTime.UtcNow,
                WorkTo = DateTime.UtcNow,
            },
            new Experience()
            {
                Id = Guid.NewGuid(),
                Position = "Position 3",
                CompanyName = "CompanyName 3",
                Responsibility = "Responsibility 3",
                Location = "Location 3",
                ProfileId = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                WorkFrom = DateTime.UtcNow,
                WorkTo = DateTime.UtcNow,
            },
        });

    }
}