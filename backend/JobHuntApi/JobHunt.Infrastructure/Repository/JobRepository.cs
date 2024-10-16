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
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Job?> GetJobByIdAsync(Guid jobId)
    {
        return await _context.Jobs
            .AsNoTracking()
            .FirstOrDefaultAsync(j => j.Id == jobId);
    }

    public async Task CreateJobAsync(Job job)
    {
        await _context.Jobs.AddAsync(job);
        
        await _context.SaveChangesAsync();
    }

    public async Task UpdateJobAsync(Job job, Guid jobId)
    {
        await _context.Jobs
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
    }

    public async Task DeleteJobAsync(Guid jobId)
    {
        await _context.Jobs
            .Where(j => j.Id == jobId)
            .ExecuteDeleteAsync();
    }
}