using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Job.DeleteJob;

public record DeleteJobByIdCommand(Guid JobId, Guid AddressId) : IRequest<BaseResponse>;