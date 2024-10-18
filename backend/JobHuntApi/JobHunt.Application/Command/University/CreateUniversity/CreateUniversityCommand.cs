using JobHunt.Application.Request;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.University.CreateUniversity;

public record CreateUniversityCommand(CreateUniversityRequest CreateUniversityRequest ,Guid ProfileId) : IRequest<BaseResponse>;