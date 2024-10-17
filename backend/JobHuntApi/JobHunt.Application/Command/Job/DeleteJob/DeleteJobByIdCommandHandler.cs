
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Job.DeleteJob;

public class DeleteJobByIdCommandHandler : IRequestHandler<DeleteJobByIdCommand>
{
    
    private readonly IJobRepository _jobRepository;

    public DeleteJobByIdCommandHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    

    public async Task Handle(DeleteJobByIdCommand request, CancellationToken cancellationToken)
    {
        await _jobRepository.DeleteJobAsync(request.JobId);
    }
}