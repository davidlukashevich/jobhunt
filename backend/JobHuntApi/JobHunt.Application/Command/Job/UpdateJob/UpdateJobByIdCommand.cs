using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.Job.UpdateJob;

public record UpdateJobByIdCommand(Guid JobId, UpdateJobRequest UpdateJobRequest) : IRequest;

