using JobHunt.Application.Exceptions.JobApplication;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response.JobApplication;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.JobApplication.GetJobApplicationById;

public class GetJobApplicationByIdQueryHandler : IRequestHandler<GetJobApplicationByIdQuery , JobApplicationByIdResponse>
{
    
    private readonly IJobApplicationRepository _jobApplicationRepository;

    public GetJobApplicationByIdQueryHandler(IJobApplicationRepository jobApplicationRepository)
    {
        _jobApplicationRepository = jobApplicationRepository;
    }

    public async Task<JobApplicationByIdResponse> Handle(GetJobApplicationByIdQuery request, CancellationToken cancellationToken)
    {
        var jobApplication = await _jobApplicationRepository.GetJobApplicationById(request.Id);

        if (jobApplication is null)
        {
            throw new JobApplicationNotFound("Job Application Not Found");
        }
        
        return jobApplication.ToJobApplicationByIdResponse();
    }
}