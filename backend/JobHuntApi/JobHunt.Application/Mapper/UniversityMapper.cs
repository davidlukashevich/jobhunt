using JobHunt.Application.DTO;
using JobHunt.Application.Request.University;
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
            StudyFrom = new DateOnly(
                    university.StudyFrom.Year,
                    university.StudyFrom.Month,
                    university.StudyFrom.Day
                ).ToString("dd/MM/yyyy"),
            
            StudyTo = new DateOnly(
                    university.StudyTo.Year,
                    university.StudyTo.Month,
                    university.StudyTo.Day
                ).ToString("dd/MM/yyyy"),
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
            StudyFrom = new DateOnly(
                    request.StudyFrom!.Year,
                    request.StudyFrom.Month,
                    request.StudyFrom.Day
                ),
            
            StudyTo = new DateOnly(
                request.StudyTo!.Year,
                request.StudyTo.Month,
                request.StudyTo.Day
            ),
            
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
            StudyFrom = new DateOnly(
                request.StudyFrom!.Year,
                request.StudyFrom.Month,
                request.StudyFrom.Day
                ),
            StudyTo = new DateOnly(
                    request.StudyTo!.Year,
                    request.StudyTo.Month,
                    request.StudyTo.Day
                ),
            
        };
    }
    
    
}