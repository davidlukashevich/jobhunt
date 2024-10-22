using JobHunt.Application.Request;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.User.UserChangePassword;

public record UserChangePasswordCommand(ChangeUserPasswordRequest ChangeUserPasswordRequest) : IRequest<BaseResponse>;