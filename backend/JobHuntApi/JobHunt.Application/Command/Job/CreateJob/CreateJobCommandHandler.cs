using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.CreateJob;

public class CreateJobCommandHandler : IRequestHandler<CreateJobCommand>
{
    
    private readonly IJobRepository _jobRepository;

    public CreateJobCommandHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task Handle(CreateJobCommand request, CancellationToken cancellationToken)
    {

        var newAddress = new Domain.Models.Address()
        {
            Id = Guid.NewGuid(),
            Country = request.CreateJobRequest.Country,
            City = request.CreateJobRequest.City,
            Street = request.CreateJobRequest.Street,
        };
        
        // Adding masstransit publish method to create new address queue
        
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
            AddressId = newAddress.Id,
        };
        
        
        await _jobRepository.CreateJobAsync(newJob);
        
        
    }
}