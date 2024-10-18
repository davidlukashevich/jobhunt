using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.CreateJob;

public class CreateJobCommandHandler : IRequestHandler<CreateJobCommand>
{
    
    private readonly IJobRepository _jobRepository;
    //private readonly ISendMessage _sendMessage;

    public CreateJobCommandHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
        //_sendMessage = sendMessage;
    }

    public async Task Handle(CreateJobCommand request, CancellationToken cancellationToken)
    {

        var createdAddress = new CreateAddress()
        {
            Id = Guid.NewGuid(),
            Country = request.CreateJobRequest.Country,
            City = request.CreateJobRequest.City,
            Street = request.CreateJobRequest.Street,
        };
        
        //await _sendMessage.Send<CreateAddress>(createdAddress, cancellationToken);
        
        
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
        };
        
        
        await _jobRepository.CreateJobAsync(newJob);
        
        
    }
}