
using JobHunt.Application.Mapper;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobs;

public class GetAllJobsQueryHandler : IRequestHandler<GetAllJobsQuery, List<JobsResponse>>
{
    
    private readonly IJobRepository _jobRepository;

    public GetAllJobsQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

   

    public async Task<List<JobsResponse>> Handle(GetAllJobsQuery query, CancellationToken cancellationToken)
    {
        var jobs =  await _jobRepository.GetAllJobsAsync();
        
        return jobs.ToJobsResponse();
    }
}