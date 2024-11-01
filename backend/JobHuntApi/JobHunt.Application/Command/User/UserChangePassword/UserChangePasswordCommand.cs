using JobHunt.Application.Request.User;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.User.UserChangePassword;

public record UserChangePasswordCommand(ChangeUserPasswordRequest ChangeUserPasswordRequest) : IRequest<BaseResponse>;