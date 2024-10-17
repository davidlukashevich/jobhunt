using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.University.UpdateUniversity;

public record UpdateUniversityCommand(Guid UniversityId ,UpdateUniversityRequest UpdateUniversityRequest) : IRequest;