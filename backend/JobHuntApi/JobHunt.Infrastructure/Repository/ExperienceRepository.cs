using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Repository;

public class ExperienceRepository : IExperienceRepository
{
    
    private readonly JobHuntDbContext _context;

    public ExperienceRepository(JobHuntDbContext context)
    {
        _context = context;
    }

    public async Task CreateExperienceAsync(Experience experience)
    {
        await _context.Experiences.AddAsync(experience);
        
        await _context.SaveChangesAsync();
    }

    public async Task<bool> DeleteExperienceAsync(Guid experienceId)
    {
       var deleteResult =  await _context.Experiences
            .Where(e => e.Id == experienceId)
            .ExecuteDeleteAsync();
       
       return deleteResult > 0;
    }

    public async  Task<bool> UpdateExperienceAsync(Experience experience, Guid experienceId)
    {
        var updateResult =  await _context.Experiences
            .Where(e => e.Id == experienceId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Position, experience.Position)
                .SetProperty(p => p.Location, experience.Location)
                .SetProperty(p => p.CompanyName, experience.CompanyName)
                .SetProperty(p => p.Responsibility, experience.Responsibility)
                .SetProperty(p => p.WorkFrom, experience.WorkFrom)
                .SetProperty(p => p.WorkTo, experience.WorkTo)
            );
        
        return updateResult > 0;
    }
}