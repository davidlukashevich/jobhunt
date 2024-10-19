using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IProfileRepository
{
    Task<Profile?> GetProfileAsync(Guid userId);
    Task UpdateProfileAsync(Profile profile, Guid userId);
    Task CreateProfileAsync(Profile profile);
}