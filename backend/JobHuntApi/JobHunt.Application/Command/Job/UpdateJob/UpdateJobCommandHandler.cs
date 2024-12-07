using System.Net;
using JobHunt.Application.BlobStorage.Image;
using JobHunt.Application.Command.Address.UpdateAddress;
using JobHunt.Application.Command.Image.UpdateImage;
using JobHunt.Application.Exceptions.Job;
using JobHunt.Application.Mapper;
using JobHunt.Application.Query.Image.GetImageById;
//using JobHunt.Application.MessageBroker;
//using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.UpdateJob;

public class UpdateJobCommandHandler : IRequestHandler<UpdateJobByIdCommand, BaseResponse>
{
    
    private readonly IJobRepository _jobRepository;
    //private readonly ISendMessage _sendMessage;
    private readonly ISender _sender;
    private readonly IImageService _imageService;

    public UpdateJobCommandHandler(
        IJobRepository jobRepository,
        //ISendMessage sendMessage,
        ISender sender, IImageService imageService)
    {
        _jobRepository = jobRepository;
        _sender = sender;
        _imageService = imageService;
        // _sendMessage = sendMessage;
    }

    public async Task<BaseResponse> Handle(UpdateJobByIdCommand request, CancellationToken cancellationToken)
    {

        var updateJobRequest = request.UpdateJobRequest;
        var updatedAddressRequest = AddressMapper.ToUpdateAddressRequest(
            updateJobRequest.City, 
            updateJobRequest.Country,
            updateJobRequest.Street);
        
        
        var updatedJob = JobMapper.ToJobModelUpdate(updateJobRequest);
        if (!await _jobRepository.UpdateJobAsync(updatedJob, request.JobId))
        {
            /*return new BaseResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "Error updating job",
            };*/
            
            throw new JobNotFoundException("Job not found");
        }

        await _sender.Send(new UpdateAddressCommand(updateJobRequest.AddressId, updatedAddressRequest), cancellationToken);
        
        if (updateJobRequest.JobImage is not null)
        {

            var imageById = await _sender.Send(new GetImageByIdQuery(updateJobRequest.ImageId), cancellationToken);

            await _imageService.DeleteImageAsync(imageById.Name!, "job" );

            await _imageService.UploadImageAsync(
                updateJobRequest.JobImage,
                "job", 
                updateJobRequest.JobImage.FileName
            );

            var updatedImageJob = ImageMapper.ToImageModelUpdate(
                updateJobRequest.JobImage.FileName,
                "job");

            await _sender.Send(new UpdateImageCommand(
                    updateJobRequest.ImageId, 
                    updatedImageJob),
                cancellationToken
            );


        }
        
        
        
        // adding masstransit publish method to update address queue

        //await _sendMessage.Send(updatedAddress, cancellationToken);

        

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Job was updated successfully!",
        };
    }
}