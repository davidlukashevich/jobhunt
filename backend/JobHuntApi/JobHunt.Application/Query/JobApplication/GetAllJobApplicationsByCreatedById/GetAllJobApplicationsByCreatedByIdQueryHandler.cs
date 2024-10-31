using JobHunt.Application.Mapper;
using JobHunt.Application.Response.JobApplication;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.JobApplication.GetAllJobApplicationsByCreatedById;

public class GetAllJobApplicationsByCreatedByIdQueryHandler : IRequestHandler<GetAllJobApplicationsByCreatedByIdQuery, List<ProfileJobApplicationsResponse>>
{
    
    private readonly IJobApplicationRepository _jobApplicationRepository;

    public GetAllJobApplicationsByCreatedByIdQueryHandler(IJobApplicationRepository jobApplicationRepository)
    {
        _jobApplicationRepository = jobApplicationRepository;
    }

    public async Task<List<ProfileJobApplicationsResponse>> Handle(GetAllJobApplicationsByCreatedByIdQuery request, CancellationToken cancellationToken)
    {
        var profileJobApplicationsResponse =
            await _jobApplicationRepository.GetAllJobsApplicationByCreatedById(request.CreatedById);
        
        return profileJobApplicationsResponse.ToProfileJobApplicationsResponse();
    }
}