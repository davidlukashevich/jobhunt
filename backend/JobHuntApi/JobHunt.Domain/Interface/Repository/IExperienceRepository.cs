using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IExperienceRepository
{
    Task CreateExperienceAsync(Experience experience);
    Task<bool> DeleteExperienceAsync(Guid experienceId);
    Task<bool> UpdateExperienceAsync(Experience experience, Guid experienceId);
}