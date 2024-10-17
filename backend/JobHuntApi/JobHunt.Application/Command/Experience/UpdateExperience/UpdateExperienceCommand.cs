using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.Experience.UpdateExperience;

public record UpdateExperienceCommand(Guid ExperienceId, UpdateExperienceRequest UpdateExperienceRequest) : IRequest;