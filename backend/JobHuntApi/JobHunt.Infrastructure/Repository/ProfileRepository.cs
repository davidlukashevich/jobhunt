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

    public async Task<Profile?> GetProfileAsync(Guid userId)
    {
        return await _context.Profiles
            .Include(p => p.Address)
            .Include(p => p.Universities)
            .Include(p => p.Experiences)
            .AsSplitQuery()
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == userId);
        
    }

    public async Task UpdateProfileAsync(Profile profile, Guid userId)
    {
        await _context.Profiles
            .Where(p => p.Id == profile.Id)
            .ExecuteUpdateAsync(s => s
                    
                .SetProperty(p => p.Name, profile.Name)
                .SetProperty(p => p.Email, profile.Email)
                .SetProperty(p => p.Phone, profile.Phone)
                .SetProperty(p => p.Lastname, profile.Lastname)
                .SetProperty(p => p.Name, profile.Name)
                .SetProperty(p => p.Email, profile.Email)
                .SetProperty(p => p.Avatar, profile.Avatar)
            );
    }

    public async Task CreateProfileAsync(Profile profile)
    {
        await _context.Profiles.AddAsync(profile);
        
        await _context.SaveChangesAsync();
    }
}