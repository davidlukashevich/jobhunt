using JobHunt.Application.DTO;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class UniversityMapper
{
    public static UniversityDTO ToUniversityDTO(this University university)
    {
        return new UniversityDTO()
        {
            Id = university.Id,
            UniversityName = university.UniversityName,
            EducationLevel = university.EducationLevel,
            FieldOfStudy = university.FieldOfStudy,
            Specialization = university.Specialization,
            StudyFrom = university.StudyFrom,
            StudyTo = university.StudyTo,
        };
    }
    
    
}