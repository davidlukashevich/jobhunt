using System.Net;
using JobHunt.Application.Response.User;
using JobHunt.Application.Service;
using JobHunt.Application.SingInManager;
using JobHunt.Infrastructure.Identity.UserManager;
using MediatR;



namespace JobHunt.Application.Command.User.UserLogin;

public class UserLoginCommandHandler : IRequestHandler<UserLoginCommand ,UserLoginResponse>
{
    
    private readonly IApplicationSignInManager _signInManager;
    private readonly IApplicationUserManager _userManager;
    private readonly ITokenService _tokenService;
    

    public UserLoginCommandHandler(IApplicationSignInManager signInManager, IApplicationUserManager userManager, ITokenService tokenService)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _tokenService = tokenService;
        
    }

    public async Task<UserLoginResponse> Handle(UserLoginCommand request, CancellationToken cancellationToken)
    {

        var userByEmail = await _userManager.FindByEmailAsync(request.UserLoginRequest.Email!);
    
        if (userByEmail is null)
        {
            return new UserLoginResponse()
            {
                StatusCode = HttpStatusCode.NotFound,
                Message = "User not found"
            };

            
        }

        
        var signInResult = await _signInManager.CheckPasswordSignInAsync(userByEmail, request.UserLoginRequest.Password!);

        if (!signInResult)
        {
            return new UserLoginResponse()
            {
                StatusCode = HttpStatusCode.Unauthorized,
                Message = "Wrong email or password"
            };
        }

        var userRole = await _userManager.GetRoleByUserEmailAsync(userByEmail.Email!);
        var token =  _tokenService.GenerateToken(userByEmail.Email!, userRole);
        
        return new UserLoginResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "User was logged in successfully",
            Token =  token
        };
    }
}