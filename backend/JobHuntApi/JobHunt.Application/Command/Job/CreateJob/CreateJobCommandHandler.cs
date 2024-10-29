using System.Net;
using JobHunt.Application.BlobStorage;
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.CreateJob;

public class CreateJobCommandHandler : IRequestHandler<CreateJobCommand, BaseResponse>
{
    
    private readonly IJobRepository _jobRepository;
    private readonly ISendMessage _sendMessage;
    private readonly IImageService _imageService;

    public CreateJobCommandHandler(IJobRepository jobRepository, ISendMessage sendMessage, IImageService imageService)
    {
        _jobRepository = jobRepository;
        _sendMessage = sendMessage;
        _imageService = imageService;
    }

    public async Task<BaseResponse> Handle(CreateJobCommand request, CancellationToken cancellationToken)
    {
        
        var commandRequest = request.CreateJobRequest;
        

        var createdAddress = new CreateAddress()
        {
            Id = Guid.NewGuid(),
            Country = request.CreateJobRequest.Country,
            City = request.CreateJobRequest.City,
            Street = request.CreateJobRequest.Street,
        };
        
        await _sendMessage.Send<CreateAddress>(createdAddress, cancellationToken);
        
        
        var newJob = new Domain.Models.Job()
        {
            Id = Guid.NewGuid(),
            Title = request.CreateJobRequest.Title,
            CompanyName = request.CreateJobRequest.CompanyName,
            OperationMode = request.CreateJobRequest.OperationMode,
            ContractType = request.CreateJobRequest.ContractType,
            JobLevel = request.CreateJobRequest.JobLevel,
            Responsibilities = request.CreateJobRequest.Responsibilities,
            Requirements = request.CreateJobRequest.Requirements,
            AddressId = createdAddress.Id,
            Type = request.CreateJobRequest.Type,
            Technology = request.CreateJobRequest.Technology,
            CreatedBy = request.CreateJobRequest.CreatedBy,
            CompanyLogo = $"https://jobhuntstorage.blob.core.windows.net/images/job_{commandRequest.CreatedBy}{Path.GetExtension(commandRequest.File.FileName)}"
        };

        await _imageService.UploadImageAsync(commandRequest.File, commandRequest.CreatedBy, "job");
        
        
        await _jobRepository.CreateJobAsync(newJob);

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Job was created",
        };
    }
}