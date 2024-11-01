using JobHunt.Application.Request.Job;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Job.UpdateJob;

public record UpdateJobByIdCommand(Guid JobId, UpdateJobRequest UpdateJobRequest) : IRequest<BaseResponse>;

