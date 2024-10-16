using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Repository;

public class UniversityRepository : IUniversityRepository
{
    
    private readonly JobHuntDbContext _context;

    public UniversityRepository(JobHuntDbContext context)
    {
        _context = context;
    }

    public async Task CreateUniversityAsync(University university)
    {
        await _context.Universities.AddAsync(university);
          
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUniversityAsync(Guid universityId)
    {
        await _context.Universities
            .Where(uni => uni.Id == universityId)
            .ExecuteDeleteAsync();
    }

    public async Task UpdateUniversityAsync(University university, Guid universityId)
    {
        await _context.Universities
            .Where(uni => uni.Id == universityId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.UniversityName, university.UniversityName)
                .SetProperty(p => p.EducationLevel, university.EducationLevel)
                .SetProperty(p => p.FieldOfStudy, university.FieldOfStudy)
                .SetProperty(p => p.Specialization, university.Specialization)
                .SetProperty(p => p.StudyFrom, university.StudyFrom)
                .SetProperty(p => p.StudyTo, university.StudyTo)
            );
    }
}