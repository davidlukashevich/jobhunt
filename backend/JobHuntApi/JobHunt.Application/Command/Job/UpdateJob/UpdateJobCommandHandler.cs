using System.Net;
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.UpdateJob;

public class UpdateJobCommandHandler : IRequestHandler<UpdateJobByIdCommand, BaseResponse>
{
    
    private readonly IJobRepository _jobRepository;
    private readonly ISendMessage _sendMessage;

    public UpdateJobCommandHandler(IJobRepository jobRepository, ISendMessage sendMessage)
    {
        _jobRepository = jobRepository;
        _sendMessage = sendMessage;
    }

    public async Task<BaseResponse> Handle(UpdateJobByIdCommand request, CancellationToken cancellationToken)
    {
        var updatedAddress = new UpdateAddress()
        {
            Id = request.UpdateJobRequest.AddressId,
            City = request.UpdateJobRequest.City,
            Country = request.UpdateJobRequest.Country,
            Street = request.UpdateJobRequest.Street,
        };
        
        
        // adding masstransit publish method to update address queue

        await _sendMessage.Send(updatedAddress, cancellationToken);

        var updatedJob = new Domain.Models.Job()
        {
            Title = request.UpdateJobRequest.Title,
            CompanyName = request.UpdateJobRequest.CompanyName,
            OperationMode = request.UpdateJobRequest.OperationMode,
            ContractType = request.UpdateJobRequest.ContractType,
            JobLevel = request.UpdateJobRequest.JobLevel,
            Responsibilities = request.UpdateJobRequest.Responsibilities,
            Requirements = request.UpdateJobRequest.Requirements,
            Type = request.UpdateJobRequest.Type,
            Technology = request.UpdateJobRequest.Technology,

        };
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
            Message = "Job was updated",
        };
    }
}