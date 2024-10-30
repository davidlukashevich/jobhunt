using JobHunt.Application.Mapper;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Interface.Repository;
using MediatR;


namespace JobHunt.Application.Query.Job.GetAllJobsByTitle
{
    public class GetAllJobsByTitleQueryHandler : IRequestHandler<GetAllJobsByTitleQuery, List<JobsResponse>>
    {

        private readonly IJobRepository _jobRepository;

        public GetAllJobsByTitleQueryHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<List<JobsResponse>> Handle(GetAllJobsByTitleQuery request, CancellationToken cancellationToken)
        {

            var jobsByTitle = await _jobRepository.GetAllJobsByTitleAsync(request.Title);

            return jobsByTitle.ToJobsResponse();
        }
    }
}
