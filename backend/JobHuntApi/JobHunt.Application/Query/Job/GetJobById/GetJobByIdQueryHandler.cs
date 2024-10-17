using JobHunt.Application.Query.Job.GetJobById;
using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using MediatR;

namespace JobHunt.Application.Query.Job.GetJobById;

public class GetJobByIdQueryHandler : IRequestHandler<GetJobByIdQuery, Domain.Models.Job>
{
    private readonly IJobRepository _jobRepository;

    public GetJobByIdQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<Domain.Models.Job> Handle(GetJobByIdQuery query, CancellationToken cancellationToken)
    {
        return await _jobRepository.GetJobByIdAsync(query.JobId);
    }
}