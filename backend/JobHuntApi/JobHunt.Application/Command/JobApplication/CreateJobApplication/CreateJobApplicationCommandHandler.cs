using System.Net;
using JobHunt.Application.BlobStorage.Files;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using MediatR;

namespace JobHunt.Application.Command.JobApplication.CreateJobApplication;

public class CreateJobApplicationCommandHandler : IRequestHandler<CreateJobApplicationCommand, BaseResponse>
{
    
    private readonly IJobApplicationRepository _jobApplicationRepository;
    private readonly IFileService _fileService;

    public CreateJobApplicationCommandHandler(IJobApplicationRepository jobApplicationRepository, IFileService fileService)
    {
        _jobApplicationRepository = jobApplicationRepository;
        _fileService = fileService;
    }

    public async Task<BaseResponse> Handle(CreateJobApplicationCommand request, CancellationToken cancellationToken)
    {
        var createJobApplicationRequest = request.CreateJobApplicationRequest;
        
        var newJobApplication = JobApplicationMapper.ToJobApplicationModelCreate(createJobApplicationRequest);
        
        await _jobApplicationRepository.CreateJobApplicationsAsync(newJobApplication);

        await _fileService.UploadCvAsync(createJobApplicationRequest.Cv, "files");
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Job application was created successfully!"
        };
    }
}