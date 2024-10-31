using JobHunt.Application.Response.JobApplication;
using MediatR;

namespace JobHunt.Application.Query.JobApplication.GetJobApplicationsByJobId;

public record GetJobApplicationsByJobIdQuery(Guid JobId) : IRequest<List<JobApplicationsByJobIdResponse>>;