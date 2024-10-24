using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IUniversityRepository
{
    Task CreateUniversityAsync(University university);
    Task<bool> DeleteUniversityAsync(Guid universityId);
    Task<bool> UpdateUniversityAsync(University university, Guid universityId);
}