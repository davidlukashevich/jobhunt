using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Experience.DeleteExperience;

public record DeleteExperienceCommand(Guid ExperienceId) : IRequest<BaseResponse>;