using JobHunt.Application.Request;
using JobHunt.Application.Response.User;
using MediatR;

namespace JobHunt.Application.Command.User.UserRegister;

public record UserRegisterCommand(UserRegisterRequest UserRegisterRequest) : IRequest<UserRegisterResponse>;
