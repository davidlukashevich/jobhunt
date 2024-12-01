using JobHunt.Application.DTO;
using JobHunt.Application.Request.Profile;
using JobHunt.Application.Response;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Command.Profile.CreateProfile;

public record CreateProfileCommand(CreateProfileRequest CreateProfileRequest) : IRequest<BaseResponse>;