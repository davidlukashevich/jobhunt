using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IProfileRepository
{
    Task<Profile?> GetProfileAsync(Guid userId);
    Task<bool> UpdateProfileAsync(Profile profile, Guid profileId);
    Task CreateProfileAsync(Profile profile);
}