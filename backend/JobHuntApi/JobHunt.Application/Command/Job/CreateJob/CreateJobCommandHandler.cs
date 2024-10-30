using System.Net;
using JobHunt.Application.BlobStorage;
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
        

        await _sender.Send(new CreateAddressCommand(createdAddress), cancellationToken);


        var newJob = JobMapper.ToJobModelCreate(request.CreateJobRequest, createdAddress.Id);
        

        var jobLogo = ImageMapper.ToImageModelCreate(commandRequest.File!, newJob.Id);
        

        
        await _sender.Send(new CreateImageCommand(jobLogo), cancellationToken);

        await _imageService.UploadImageAsync(commandRequest.File, commandRequest.CreatedBy, "job");
        
        
        await _jobRepository.CreateJobAsync(newJob);

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Job was created successfully!",
        };
    }
}