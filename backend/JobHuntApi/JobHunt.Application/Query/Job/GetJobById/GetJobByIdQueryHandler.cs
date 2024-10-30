using JobHunt.Application.Mapper;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Job.GetJobById;

public class GetJobByIdQueryHandler : IRequestHandler<GetJobByIdQuery, SingleJobResponse>
{
    private readonly IJobRepository _jobRepository;

    public GetJobByIdQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<SingleJobResponse> Handle(GetJobByIdQuery query, CancellationToken cancellationToken)
    {

        
        
        var jobById =  await _jobRepository.GetJobByIdAsync(query.JobId);

        if (jobById is null)
        {
            return null;
        }

        
        
        return jobById.ToSingleJobResponse();
    }
}