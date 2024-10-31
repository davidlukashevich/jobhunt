using JobHunt.Application.Response.Job;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobsByCreatedById;

public record GetAllJobsByCreatedByIdQuery(string CreatedById) : IRequest<List<JobsResponse>>;
