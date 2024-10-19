using JobHunt.Application.DTO;
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
        };
    }
}