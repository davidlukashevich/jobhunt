using MediatR;

namespace JobHunt.Application.Command.Job.DeleteJob;

public record DeleteJobByIdCommand(Guid JobId) : IRequest;