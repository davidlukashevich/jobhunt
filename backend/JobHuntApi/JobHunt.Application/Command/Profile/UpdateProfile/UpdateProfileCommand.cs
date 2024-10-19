using JobHunt.Application.Request;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Profile.UpdateProfile;

public record UpdateProfileCommand(UpdateProfileRequest UpdateProfileRequest,  Guid ProfileId) : IRequest<BaseResponse>;