
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobs;

public record GetAllJobsQuery() : IRequest<List<Domain.Models.Job>>;