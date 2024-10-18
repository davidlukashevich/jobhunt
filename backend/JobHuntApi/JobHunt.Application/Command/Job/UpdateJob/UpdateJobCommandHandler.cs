using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.UpdateJob;

public class UpdateJobCommandHandler : IRequestHandler<UpdateJobByIdCommand>
{
    
    private readonly IJobRepository _jobRepository;
    //private readonly ISendMessage _sendMessage;

    public UpdateJobCommandHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
       // _sendMessage = sendMessage;
    }

    public async Task Handle(UpdateJobByIdCommand request, CancellationToken cancellationToken)
    {
        var updatedAddress = new UpdateAddress()
        {
            Id = request.JobId,
            City = request.UpdateJobRequest.City,
            Country = request.UpdateJobRequest.Country,
            Street = request.UpdateJobRequest.Street,
        };
        
        
        // adding masstransit publish method to update address queue

        //await _sendMessage.Send<UpdateAddress>(updatedAddress, cancellationToken);

        var updatedJob = new Domain.Models.Job()
        {
            Title = request.UpdateJobRequest.Title,
            CompanyName = request.UpdateJobRequest.CompanyName,
            OperationMode = request.UpdateJobRequest.OperationMode,
            ContractType = request.UpdateJobRequest.ContractType,
            JobLevel = request.UpdateJobRequest.JobLevel,
            Responsibilities = request.UpdateJobRequest.Responsibilities,
            Requirements = request.UpdateJobRequest.Requirements,

        };
        
        await _jobRepository.UpdateJobAsync(updatedJob, request.JobId);
    }
}