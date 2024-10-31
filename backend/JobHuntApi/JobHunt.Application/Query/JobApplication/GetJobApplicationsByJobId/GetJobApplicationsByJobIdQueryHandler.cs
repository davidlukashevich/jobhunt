using JobHunt.Application.Mapper;
using JobHunt.Application.Response.JobApplication;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.JobApplication.GetJobApplicationsByJobId;

public class GetJobApplicationsByJobIdQueryHandler : IRequestHandler<GetJobApplicationsByJobIdQuery, List<JobApplicationsByJobIdResponse>>
{
    private readonly IJobApplicationRepository _jobApplicationRepository;

    public GetJobApplicationsByJobIdQueryHandler(IJobApplicationRepository jobApplicationRepository)
    {
        _jobApplicationRepository = jobApplicationRepository;
    }

    public async Task<List<JobApplicationsByJobIdResponse>> Handle(GetJobApplicationsByJobIdQuery request, CancellationToken cancellationToken)
    {
        var jobApplications = await _jobApplicationRepository.GetAllJobsApplicationByJobId(request.JobId);
        
        return jobApplications.ToJobApplicationsByJobIdResponse();
    }
}