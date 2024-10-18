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
        builder.Property(x => x.ProfileId).HasColumnName("profile_id");

        builder.HasData(new List<University>()
        {
            new University()
            {
                Id = Guid.NewGuid(),
                UniversityName = "Vistula",
                EducationLevel = "Bachelor",
                Specialization = "Computer Science",
                ProfileId = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                FieldOfStudy = "Field of Study",
                StudyFrom = DateTime.UtcNow,
                StudyTo = DateTime.UtcNow,
            },
            new University()
            {
                Id = Guid.NewGuid(),
                UniversityName = "Vistula 2",
                EducationLevel = "Bachelor 2",
                Specialization = "Computer Science 2",
                ProfileId = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                FieldOfStudy = "Field of Study 2",
                StudyFrom = DateTime.UtcNow,
                StudyTo = DateTime.UtcNow,
            },
            new University()
            {
                Id = Guid.NewGuid(),
                UniversityName = "Vistula 3",
                EducationLevel = "Bachelor 3",
                Specialization = "Computer Science 3",
                ProfileId = Guid.Parse("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                FieldOfStudy = "Field of Study 3",
                StudyFrom = DateTime.UtcNow,
                StudyTo = DateTime.UtcNow,
            },
        });

    }
}