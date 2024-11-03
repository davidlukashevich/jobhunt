using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class UniversityEntityConfiguration : IEntityTypeConfiguration<University>
{
    public void Configure(EntityTypeBuilder<University> builder)
    {
        builder.ToTable("universities");
        builder.HasKey(k => k.Id);
        
        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.UniversityName).HasColumnName("university_name").IsRequired();
        builder.Property(p => p.EducationLevel).HasColumnName("education_level").IsRequired();
        builder.Property(p => p.FieldOfStudy).HasColumnName("field_of_study").IsRequired();
        builder.Property(p => p.Specialization).HasColumnName("specialization").IsRequired();
        builder.Property(p => p.StudyFrom).HasColumnName("study_from").IsRequired();
        builder.Property(p => p.StudyTo).HasColumnName("study_to").IsRequired();
        builder.Property(p => p.ProfileId).HasColumnName("profile_id").IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("created_at").IsRequired();
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at").IsRequired();
        
        

       

    }
}