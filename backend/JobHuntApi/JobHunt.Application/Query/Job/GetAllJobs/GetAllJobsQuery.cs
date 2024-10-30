
using JobHunt.Application.Response.Job;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobs;

public record GetAllJobsQuery : IRequest<List<JobsResponse>>;