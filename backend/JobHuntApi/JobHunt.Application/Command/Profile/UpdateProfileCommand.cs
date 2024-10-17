using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.Profile;

public record UpdateProfileCommand(UpdateProfileRequest UpdateProfileRequest,  Guid ProfileId) : IRequest;