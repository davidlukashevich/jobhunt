using JobHunt.Application.DTO;
using JobHunt.Application.Request;
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
            WorkFrom = experience.WorkFrom,
            WorkTo = experience.WorkTo,
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
            WorkFrom = createExperienceRequest.WorkFrom,
            WorkTo = createExperienceRequest.WorkTo,
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
            WorkFrom = updateExperienceRequest.WorkFrom,
            WorkTo = updateExperienceRequest.WorkTo,
        };
    }
}