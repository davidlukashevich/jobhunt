using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IUniversityRepository
{
    Task CreateUniversityAsync(University university);
    Task DeleteUniversityAsync(Guid universityId);
    Task UpdateUniversityAsync(University university, Guid universityId);
}