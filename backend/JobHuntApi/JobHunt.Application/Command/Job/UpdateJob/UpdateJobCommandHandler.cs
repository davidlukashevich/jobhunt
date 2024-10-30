using System.Net;
using JobHunt.Application.Command.Address.UpdateAddress;
using JobHunt.Application.Mapper;
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

    public UpdateJobCommandHandler(
        IJobRepository jobRepository,
        //ISendMessage sendMessage,
        ISender sender)
    {
        _jobRepository = jobRepository;
        _sender = sender;
       // _sendMessage = sendMessage;
    }

    public async Task<BaseResponse> Handle(UpdateJobByIdCommand request, CancellationToken cancellationToken)
    {

        var updateJobRequest = request.UpdateJobRequest;
        var updatedAddressRequest = AddressMapper.ToUpdateAddressRequest(
            updateJobRequest.City, 
            updateJobRequest.Country,
            updateJobRequest.Street);
        
        

        await _sender.Send(new UpdateAddressCommand(updateJobRequest.AddressId, updatedAddressRequest), cancellationToken);
        
        
        
        // adding masstransit publish method to update address queue

        //await _sendMessage.Send(updatedAddress, cancellationToken);

        var updatedJob = JobMapper.ToJobModelUpdate(updateJobRequest);
        if (!await _jobRepository.UpdateJobAsync(updatedJob, request.JobId))
        {
            return new BaseResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "Error updating job",
            };
        }
        

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Job was updated successfully!",
        };
    }
}