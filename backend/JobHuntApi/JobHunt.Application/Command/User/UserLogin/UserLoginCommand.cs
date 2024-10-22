using JobHunt.Application.Request;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.User.UserLogin;

public record UserLoginCommand(UserLoginRequest UserLoginRequest) : IRequest<BaseResponse>;
