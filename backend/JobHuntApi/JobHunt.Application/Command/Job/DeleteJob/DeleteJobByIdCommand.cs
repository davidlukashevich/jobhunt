using MediatR;

namespace JobHunt.Application.Command.Job;

public record DeleteJobByIdCommand(Guid JobId) : IRequest;