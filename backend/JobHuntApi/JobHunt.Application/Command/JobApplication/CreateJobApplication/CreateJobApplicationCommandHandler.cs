using System.Net;
using JobHunt.Application.BlobStorage.Files;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;

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
        
        var uniqueFileGuid = Guid.NewGuid();
        
        var newJobApplication = JobApplicationMapper.ToJobApplicationModelCreate(createJobApplicationRequest,uniqueFileGuid);
        
        await _jobApplicationRepository.CreateJobApplicationsAsync(newJobApplication);

        if (!await _fileService.IsFileExistsAsync(createJobApplicationRequest.Cv, uniqueFileGuid))
        {
            await _fileService.UploadCvAsync(createJobApplicationRequest.Cv, uniqueFileGuid);
        }

       
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Job application was created successfully!"
        };
    }
}