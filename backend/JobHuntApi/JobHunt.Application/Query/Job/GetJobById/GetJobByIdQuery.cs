
using MediatR;

namespace JobHunt.Application.Query.Job.GetJobById;

public record GetJobByIdQuery(Guid JobId) : IRequest<Domain.Models.Job>;