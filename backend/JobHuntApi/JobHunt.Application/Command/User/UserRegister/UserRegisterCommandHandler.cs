using System.Net;
using JobHunt.Application.Response.User;
using JobHunt.Infrastructure.Identity.UserManager;
using MediatR;


namespace JobHunt.Application.Command.User.UserRegister;

public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, UserRegisterResponse>
{
    
    private readonly IApplicationUserManager _applicationUserManager;

    public UserRegisterCommandHandler(IApplicationUserManager applicationUserManager)
    {
        _applicationUserManager = applicationUserManager;
    }

    public async Task<UserRegisterResponse> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        var userByEmail = await _applicationUserManager.IsUserExistsAsync(request.UserRegisterRequest.Email);

        if (userByEmail)
        {
            throw new Exception("User already exists");
        }

        var newUser = new Infrastructure.Identity.User()
        {
            Email = request.UserRegisterRequest.Email,
            PasswordHash = request.UserRegisterRequest.Password,
        };
        
        var result = await _applicationUserManager.RegisterUserAsync(newUser);

        if (!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }
        
        return new UserRegisterResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "User has been registered",
            Id = "test id",
        };
    }
}