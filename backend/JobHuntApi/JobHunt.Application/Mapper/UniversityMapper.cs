using JobHunt.Application.DTO;
using JobHunt.Application.Request;
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

    public static University ToUniversityModelCreate(CreateUniversityRequest request , Guid profileId)
    {
        return new University()
        {
            Id = Guid.NewGuid(),
            UniversityName = request.UniversityName,
            EducationLevel = request.EducationLevel,
            FieldOfStudy = request.FieldOfStudy,
            Specialization = request.Specialization,
            StudyFrom = request.StudyFrom,
            StudyTo = request.StudyTo,
            ProfileId = profileId
        };
    }
    
    public static University ToUniversityModelUpdate(UpdateUniversityRequest request)
    {
        return new University()
        {
            
            UniversityName = request.UniversityName,
            EducationLevel = request.EducationLevel,
            FieldOfStudy = request.FieldOfStudy,
            Specialization = request.Specialization,
            StudyFrom = request.StudyFrom,
            StudyTo = request.StudyTo,
            
        };
    }
    
    
}