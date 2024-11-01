using JobHunt.Application.Request.Experience;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Experience.CreateExperience;

public record CreateExperienceCommand(CreateExperienceRequest CreateExperienceRequest, Guid ProfileId) : IRequest<BaseResponse>;