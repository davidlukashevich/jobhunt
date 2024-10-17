using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.Experience.CreateExperience;

public record CreateExperienceCommand(CreateExperienceRequest CreateExperienceRequest) : IRequest;