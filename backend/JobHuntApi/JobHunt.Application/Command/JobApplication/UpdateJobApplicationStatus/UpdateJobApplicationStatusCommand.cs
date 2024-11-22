using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.JobApplication.UpdateJobApplicationStatus;

public record UpdateJobApplicationStatusCommand(Guid JobApplicationId, string Status) : IRequest<BaseResponse>;