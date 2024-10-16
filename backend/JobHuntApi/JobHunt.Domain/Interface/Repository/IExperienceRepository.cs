using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IExperienceRepository
{
    Task CreateExperienceAsync(Experience experience);
    Task DeleteExperienceAsync(Guid experienceId);
    Task UpdateExperienceAsync(Experience experience, Guid experienceId);
}