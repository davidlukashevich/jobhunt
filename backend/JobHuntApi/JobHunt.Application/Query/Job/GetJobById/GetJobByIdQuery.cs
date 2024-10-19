
using JobHunt.Application.Response.Job;
using MediatR;

namespace JobHunt.Application.Query.Job.GetJobById;

public record GetJobByIdQuery(Guid JobId) : IRequest<SingleJobResponse>;