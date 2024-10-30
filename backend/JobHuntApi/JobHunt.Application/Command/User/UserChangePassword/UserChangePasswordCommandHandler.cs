using System.Net;
using JobHunt.Application.Response;
using JobHunt.Application.Response.User;
using JobHunt.Infrastructure.Identity.UserManager;
using MediatR;


namespace JobHunt.Application.Command.User.UserChangePassword;

public class UserChangePasswordCommandHandler : IRequestHandler<UserChangePasswordCommand, BaseResponse>
{
    
    private readonly IApplicationUserManager _applicationUserManager;
    

    public UserChangePasswordCommandHandler(IApplicationUserManager applicationUserManager)
    {
        _applicationUserManager = applicationUserManager;
        
    }

    public async Task<BaseResponse> Handle(UserChangePasswordCommand request, CancellationToken cancellationToken)
    {

        var userByEmail = await _applicationUserManager.FindByEmailAsync(request.ChangeUserPasswordRequest.Email);

        if (userByEmail is null)
        {
          
            return new BaseResponse()
            {
                StatusCode = HttpStatusCode.NotFound,
                Message = "User not found"
            };
        }
        
        var changePasswordResult = await _applicationUserManager.ChangeUserPasswordAsync(userByEmail,
            request.ChangeUserPasswordRequest.CurrentPassword,
            request.ChangeUserPasswordRequest.NewPassword);

        if (!changePasswordResult.Succeeded)
        {
            return new UserChangePasswordError()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "Error changing password",
                Errors = changePasswordResult.Errors.Select(x => x.Description).ToList()
            };
        }

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Password changed successfully!",
        };
    }
}