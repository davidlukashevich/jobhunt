using System.Net;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using MediatR;

namespace JobHunt.Application.Command.JobApplication.CreateJobApplication;

public class CreateJobApplicationCommandHandler : IRequestHandler<CreateJobApplicationCommand, BaseResponse>
{
    
    private readonly IJobApplicationRepository _jobApplicationRepository;

    public CreateJobApplicationCommandHandler(IJobApplicationRepository jobApplicationRepository)
    {
        _jobApplicationRepository = jobApplicationRepository;
    }

    public async Task<BaseResponse> Handle(CreateJobApplicationCommand request, CancellationToken cancellationToken)
    {
        var createJobApplicationRequest = request.CreateJobApplicationRequest;
        
        var newJobApplication = JobApplicationMapper.ToJobApplicationModelCreate(createJobApplicationRequest);
        
        await _jobApplicationRepository.CreateJobApplicationsAsync(newJobApplication);
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Job application was created successfully!"
        };
    }
}