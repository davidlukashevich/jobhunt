using JobHunt.Application.Request.Profile;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Profile.CreateProfile;

public record CreateProfileCommand(CreateProfileRequest CreateProfileRequest) : IRequest<BaseResponse>;