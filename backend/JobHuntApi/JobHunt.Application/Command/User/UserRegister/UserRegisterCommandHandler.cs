using System.Net;
using JobHunt.Application.Response.User;
using JobHunt.Application.Service;
using JobHunt.Infrastructure.Identity.UserManager;
using MediatR;


namespace JobHunt.Application.Command.User.UserRegister;

public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, UserRegisterResponse>
{
    
    private readonly IApplicationUserManager _applicationUserManager;
    private readonly ITokenService _tokenService;

    public UserRegisterCommandHandler(IApplicationUserManager applicationUserManager, ITokenService tokenService)
    {
        _applicationUserManager = applicationUserManager;
        _tokenService = tokenService;
    }

    public async Task<UserRegisterResponse> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        var userByEmail = await _applicationUserManager.IsUserExistsAsync(request.UserRegisterRequest.Email);

        if (userByEmail)
        {
            return new UserRegisterResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "User already exists!"
            };
        }

        var newUser = new Infrastructure.Identity.User()
        {
            Email = request.UserRegisterRequest.Email,
            UserName = request.UserRegisterRequest.Username
        };
        
        var result = await _applicationUserManager.RegisterUserAsync(newUser, request.UserRegisterRequest.Password, request.UserRegisterRequest.Role);

        if (!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }
        
        var roleList = new List<string>(request.UserRegisterRequest.Role.Split(','));

        var token = _tokenService.GenerateToken(newUser.Email,  roleList);
        
        return new UserRegisterResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "User has been registered",
            Id = newUser.Id,
            Token = token,
            UserId = newUser.Id
        };
    }
}