using JobHunt.Application.Mapper;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobsByFilter;

public class GetAllJobsByFilterQueryHandler : IRequestHandler<GetAllJobsByFilterQuery, List<JobsResponse>>
{
    
    private readonly IJobRepository _jobRepository;

    public GetAllJobsByFilterQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<List<JobsResponse>> Handle(GetAllJobsByFilterQuery request, CancellationToken cancellationToken)
    {
        var jobsByFilter =
            await _jobRepository.GetAllJobsByFilterAsync(request.Type, request.Technology, request.Level);
        
        return jobsByFilter.ToJobsResponse();
    }
}