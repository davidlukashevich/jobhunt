using System.Net;
using JobHunt.Application.BlobStorage.Image;
using JobHunt.Application.Command.Address.CreateAddress;
using JobHunt.Application.Command.Image.CreateImage;
using JobHunt.Application.Mapper;
//using JobHunt.Application.MessageBroker;
//using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.CreateJob;

public class CreateJobCommandHandler : IRequestHandler<CreateJobCommand, BaseResponse>
{
    
    private readonly IJobRepository _jobRepository;
   // private readonly ISendMessage _sendMessage;
    private readonly IImageService _imageService;
    private readonly ISender _sender;

    public CreateJobCommandHandler(
        IJobRepository jobRepository,
        //ISendMessage sendMessage,
        IImageService imageService, ISender sender)
    {
        _jobRepository = jobRepository;
       // _sendMessage = sendMessage;
        _imageService = imageService;
        _sender = sender;
    }

    public async Task<BaseResponse> Handle(CreateJobCommand request, CancellationToken cancellationToken)
    {
        
        var commandRequest = request.CreateJobRequest;

        
        
        

        var createdAddress = AddressMapper.ToCreateAddressRequest(commandRequest.City, commandRequest.Country, commandRequest.Street);
        
        var jobLogo = ImageMapper.ToImageModelCreate(commandRequest.File!.FileName, "job");
        
        var newJob = JobMapper.ToJobModelCreate(request.CreateJobRequest, createdAddress.Id, jobLogo.Id);
        
        await _sender.Send(new CreateAddressCommand(createdAddress), cancellationToken);
        
        await _sender.Send(new CreateImageCommand(jobLogo), cancellationToken);
        
        await _jobRepository.CreateJobAsync(newJob);
        
        

        await _imageService.UploadImageAsync(commandRequest.File!,  "job", commandRequest.File!.FileName);
        
        
        

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Job was created successfully!",
        };
    }
}