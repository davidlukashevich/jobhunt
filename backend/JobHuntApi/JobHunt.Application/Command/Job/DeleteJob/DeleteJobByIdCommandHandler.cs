
using System.Net;
using JobHunt.Application.BlobStorage.Image;
using JobHunt.Application.Command.Address.DeleteAddress;
using JobHunt.Application.Command.Image.DeleteImage;
using JobHunt.Application.Exceptions.Job;
using JobHunt.Application.Query.Image.GetImageById;
//using JobHunt.Application.MessageBroker;
//using JobHunt.Application.MessageBroker.Address.DeleteAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.DeleteJob;

public class DeleteJobByIdCommandHandler : IRequestHandler<DeleteJobByIdCommand, BaseResponse>
{
    
    private readonly IJobRepository _jobRepository;
    private readonly ISender _sender;
    private readonly IImageService _imageService;
    //private readonly ISendMessage _sendMessage;

    public DeleteJobByIdCommandHandler(
        IJobRepository jobRepository, 
        ISender sender, IImageService imageService
        //ISendMessage sendMessage
        )
    {
        _jobRepository = jobRepository;
        _sender = sender;
        _imageService = imageService;
        //_sendMessage = sendMessage;
    }

    

    public async Task<BaseResponse> Handle(DeleteJobByIdCommand request, CancellationToken cancellationToken)
    {
        
        //await _sendMessage.Send(new DeleteAddress(){AddressId = request.AddressId}, cancellationToken);
        
        if (!await _jobRepository.DeleteJobAsync(request.JobId))
        {
            throw new JobNotFoundException("Job not found");
        }
        
        var imageById = await _sender.Send(new GetImageByIdQuery(request.ImageId), cancellationToken);

        await _imageService.DeleteImageAsync(imageById.Name!, "job" );
        
        await _sender.Send(new DeleteAddressCommand(request.AddressId), cancellationToken);
        await _sender.Send(new DeleteImageCommand(request.ImageId), cancellationToken);
        

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Job was deleted successfully!",
        };
    }
}