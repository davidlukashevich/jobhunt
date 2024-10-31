using JobHunt.Application.Mapper;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobsByCreatedById;

public class GetAllJobsByCreatedByIdQueryHandler : IRequestHandler<GetAllJobsByCreatedByIdQuery, List<JobsResponse>>
{
    
    private readonly IJobRepository _jobRepository;

    public GetAllJobsByCreatedByIdQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<List<JobsResponse>> Handle(GetAllJobsByCreatedByIdQuery request, CancellationToken cancellationToken)
    {
        var jobsByCreatedByIdResponse = await _jobRepository.GetAllJobsByCreatedByIdAsync(request.CreatedById);
        
        return jobsByCreatedByIdResponse.ToJobsResponse();
    }
}