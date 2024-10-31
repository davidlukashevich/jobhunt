using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IJobApplicationRepository
{
    Task CreateJobApplicationsAsync(JobApplication jobApplication);
    Task<List<JobApplication>> GetAllJobsApplicationByJobId( Guid jobId);
    Task<JobApplication?> GetJobApplicationById( Guid jobApplicationId);
    Task<List<JobApplication>> GetAllJobsApplicationByCreatedById(string createdById);
}