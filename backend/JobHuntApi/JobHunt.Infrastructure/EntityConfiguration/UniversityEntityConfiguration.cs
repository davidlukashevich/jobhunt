using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class UniversityEntityConfiguration : IEntityTypeConfiguration<University>
{
    public void Configure(EntityTypeBuilder<University> builder)
    {
        builder.ToTable("universities");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.UniversityName).HasColumnName("university_name").IsRequired();
        builder.Property(x => x.EducationLevel).HasColumnName("education_level").IsRequired();
        builder.Property(x => x.FieldOfStudy).HasColumnName("field_of_study").IsRequired();
        builder.Property(x => x.Specialization).HasColumnName("specialization").IsRequired();
        builder.Property(x => x.StudyFrom).HasColumnName("study_from").IsRequired();
        builder.Property(x => x.StudyTo).HasColumnName("study_to").IsRequired();
        builder.Property(x => x.AddressId).HasColumnName("address_id");
        builder.Property(x => x.UserId).HasColumnName("user_id");
        
        
        
    }
}