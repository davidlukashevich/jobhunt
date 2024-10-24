using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Repository;

public class JobRepository : IJobRepository
{
    
    private readonly JobHuntDbContext _context;

    public JobRepository(JobHuntDbContext context)
    {
        _context = context;
    }

    public async Task<List<Job>> GetAllJobsAsync()
    {
        return await _context.Jobs
            .Include(j => j.Address)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Job?> GetJobByIdAsync(Guid jobId)
    {
        return await _context.Jobs
            .AsNoTracking()
            .Include(j => j.Address)
            .FirstOrDefaultAsync(j => j.Id == jobId);
    }

    public async Task CreateJobAsync(Job job)
    {
        await _context.Jobs.AddAsync(job);
        
        await _context.SaveChangesAsync();
    }

    public async Task<bool> UpdateJobAsync(Job job, Guid jobId)
    {
        var updateResult = await _context.Jobs
            .Where(j => j.Id == jobId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Title, job.Title)
                .SetProperty(p => p.CompanyName, job.CompanyName)
                .SetProperty(p => p.OperationMode, job.OperationMode)
                .SetProperty(p => p.ContractType, job.ContractType)
                .SetProperty(p => p.JobLevel, job.JobLevel)
                .SetProperty(p => p.Responsibilities, job.Responsibilities)
                .SetProperty(p => p.Requirements, job.Requirements)
            );

        return updateResult > 0;
    }

    public async Task<bool> DeleteJobAsync(Guid jobId)
    {
        var deleteResult = await _context.Jobs
            .Where(j => j.Id == jobId)
            .ExecuteDeleteAsync();
        
        return deleteResult > 0;
    }

    public async Task<List<Job>> GetAllJobsByFilterAsync(string type, string technology, string level)
    {
       
        var query = _context.Jobs
            .AsNoTracking()  
            .Include(j => j.Address)  
            .AsQueryable();  

        
        if (!string.IsNullOrEmpty(level))
        {
            query = query.Where(j => j.JobLevel == level);
        }

        if (!string.IsNullOrEmpty(type))
        {
            query = query.Where(j => j.Type == type);
        }

        if (!string.IsNullOrEmpty(technology))
        {
            query = query.Where(j => j.Technology == technology);
        }

        
        return await query.ToListAsync();
    }

    public async Task<List<Job>> GetAllJobsByTitleAsync(string title)
    {
        return await _context.Jobs
            .AsNoTracking()
            .Where(j => EF.Functions.ToTsVector("english", j.Title + " " + j.Technology + " " +j.JobLevel + " " + j.Type )
                .Matches(EF.Functions.PhraseToTsQuery("english", title)))
            .Include(j => j.Address)
            .ToListAsync();
            
    }
}