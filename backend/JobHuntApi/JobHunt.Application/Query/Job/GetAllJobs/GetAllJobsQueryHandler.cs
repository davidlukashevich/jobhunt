
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobs;

public class GetAllJobsQueryHandler : IRequestHandler<GetAllJobsQuery, List<Domain.Models.Job>>
{
    
    private readonly IJobRepository _jobRepository;

    public GetAllJobsQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

   

    public async Task<List<Domain.Models.Job>> Handle(GetAllJobsQuery query, CancellationToken cancellationToken)
    {
        return await _jobRepository.GetAllJobsAsync();
    }
}