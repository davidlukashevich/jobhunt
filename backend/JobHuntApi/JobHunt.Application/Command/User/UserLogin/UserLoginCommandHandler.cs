using System.Net;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.User.UserLogin;

public class UserLoginCommandHandler : IRequestHandler<UserLoginCommand ,BaseResponse>
{
    public async Task<BaseResponse> Handle(UserLoginCommand request, CancellationToken cancellationToken)
    {
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "User was logged in successfully",
        };
    }
}