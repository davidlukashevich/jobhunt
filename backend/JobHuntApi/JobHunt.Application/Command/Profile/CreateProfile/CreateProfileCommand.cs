using JobHunt.Application.Request;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Profile.CreateProfile;

public record CreateProfileCommand(CreateProfileRequest CreateProfileRequest) : IRequest<BaseResponse>;