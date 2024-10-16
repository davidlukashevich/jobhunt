using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IJobRepository
{
    Task<List<Job>> GetAllJobsAsync();
    Task<Job> GetJobByIdAsync(Guid jobId);
    Task CreateJobAsync(Job job);
    Task UpdateJobAsync(Job job, Guid jobId);
    Task DeleteJobAsync(Guid jobId);
}