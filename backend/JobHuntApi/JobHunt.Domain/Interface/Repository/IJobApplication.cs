using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IJobApplication
{
    Task CreateJobApplicationsAsync(JobApplication jobApplication);
    Task<List<JobApplication>> GetAllJobsApplicationByJobId( Guid jobId);
}