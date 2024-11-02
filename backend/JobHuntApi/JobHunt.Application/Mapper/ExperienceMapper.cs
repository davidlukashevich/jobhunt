using JobHunt.Application.DTO;
using JobHunt.Application.Request.Experience;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class ExperienceMapper
{
    public static ExperienceDTO ToExperienceDto(this Experience experience)
    {
        return new ExperienceDTO()
        {
            Id = experience.Id,
            Position = experience.Position,
            CompanyName = experience.CompanyName,
            Responsibility = experience.Responsibility,
            WorkFrom = new DateOnly(
                experience.WorkFrom.Year,
                experience.WorkFrom.Month,
                experience.WorkFrom.Day
                ).ToString("dd/MM/yyyy"),
            
            WorkTo = new DateOnly(
                experience.WorkTo.Year,
                experience.WorkTo.Month,
                experience.WorkTo.Day
                ).ToString("dd/MM/yyyy"),
            Location = experience.Location,
        };
    }

    public static Experience ToExperienceModelCreate(CreateExperienceRequest createExperienceRequest, Guid profileId)
    {
        return new Experience()
        {
            Id = Guid.NewGuid(),
            Position = createExperienceRequest.Position,
            Location = createExperienceRequest.Location,
            CompanyName = createExperienceRequest.CompanyName,
            Responsibility = createExperienceRequest.Responsibility,
            WorkFrom = new DateOnly(
                createExperienceRequest.WorkFrom!.Year,
                createExperienceRequest.WorkFrom.Month,
                createExperienceRequest.WorkFrom.Day
                
                ),
            WorkTo = new DateOnly(
                createExperienceRequest.WorkTo!.Year,
                createExperienceRequest.WorkTo.Month,
                createExperienceRequest.WorkTo.Day
                ),
            ProfileId = profileId
        };
    }
    public static Experience ToExperienceModelUpdate(UpdateExperienceRequest updateExperienceRequest)
    {
        return new Experience()
        {
            Position = updateExperienceRequest.Position,
            Location = updateExperienceRequest.Location,
            CompanyName = updateExperienceRequest.CompanyName,
            Responsibility = updateExperienceRequest.Responsibility,
            WorkFrom = new DateOnly(
                    updateExperienceRequest.WorkFrom!.Year,
                    updateExperienceRequest.WorkFrom.Month,
                    updateExperienceRequest.WorkFrom.Day
                ),
            WorkTo = new DateOnly(
                    updateExperienceRequest.WorkTo!.Year,
                    updateExperienceRequest.WorkTo.Month,
                    updateExperienceRequest.WorkTo.Day
                ),
        };
    }
}