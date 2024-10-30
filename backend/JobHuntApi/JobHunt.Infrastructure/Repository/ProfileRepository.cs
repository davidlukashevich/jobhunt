using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Repository;

public class ProfileRepository : IProfileRepository
{
    private readonly JobHuntDbContext _context;
    
    public ProfileRepository(JobHuntDbContext context)
    {
        _context = context;
    }

    public async Task<Profile?> GetProfileAsync(string userId)
    {
        return await _context.Profiles
            .Include(p => p.Address)
            .Include(p => p.Universities)
            .Include(p => p.Experiences)
            .AsSplitQuery()
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.CreatedBy == userId);
        
    }

    public async Task<bool> UpdateProfileAsync(Profile profile, Guid profileId)
    {
        var updateResult = await _context.Profiles
            .Where(p => p.Id == profileId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Name, profile.Name)
                .SetProperty(p => p.ProfileImage, profile.ProfileImage)
                .SetProperty(p => p.Lastname, profile.Lastname)
                .SetProperty(p => p.Email, profile.Email)
                .SetProperty(p => p.Phone, profile.Phone)
                .SetProperty(p => p.DateOfBirth, profile.DateOfBirth)
                .SetProperty(p => p.CreatedBy, profile.CreatedBy)
            );
        
        return updateResult > 0;
    }

    public async Task CreateProfileAsync(Profile profile)
    {
        await _context.Profiles.AddAsync(profile);
        
        await _context.SaveChangesAsync();
    }
}