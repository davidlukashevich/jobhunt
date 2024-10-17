using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.University.CreateUniversity;

public record CreateUniversityCommand(CreateUniversityRequest CreateUniversityRequest) : IRequest;