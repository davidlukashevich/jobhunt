using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.University.DeleteUniversity;

public record DeleteUniversityCommand(Guid UniversityId) : IRequest<BaseResponse>;