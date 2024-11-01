using JobHunt.Application.Request.University;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.University.UpdateUniversity;

public record UpdateUniversityCommand(Guid UniversityId ,UpdateUniversityRequest UpdateUniversityRequest) : IRequest<BaseResponse>;