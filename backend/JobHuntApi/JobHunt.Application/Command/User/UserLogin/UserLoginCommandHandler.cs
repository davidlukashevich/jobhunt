using System.Net;
using JobHunt.Application.Exceptions.User;
using JobHunt.Application.Response.User;
using JobHunt.Application.Service;
using JobHunt.Application.SingInManager;
using JobHunt.Infrastructure.Identity.UserManager;
using MediatR;
using Microsoft.AspNetCore.Http;


namespace JobHunt.Application.Command.User.UserLogin;

public class UserLoginCommandHandler : IRequestHandler<UserLoginCommand ,UserLoginResponse>
{
    
    private readonly IApplicationSignInManager _signInManager;
    private readonly IApplicationUserManager _userManager;
    private readonly ITokenService _tokenService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserLoginCommandHandler(IApplicationSignInManager signInManager, IApplicationUserManager userManager, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _tokenService = tokenService;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<UserLoginResponse> Handle(UserLoginCommand request, CancellationToken cancellationToken)
    {

        var userByEmail = await _userManager.FindByEmailAsync(request.UserLoginRequest.Email!);
    
        if (userByEmail is null)
        {
            throw new UserDoesNotExist("User with email address " + request.UserLoginRequest.Email + " does not exist");
            
        }

        
        var signInResult = await _signInManager.CheckPasswordSignInAsync(userByEmail, request.UserLoginRequest.Password!);

        if (!signInResult)
        {
            throw new UserWrongCredentialsException("Wrong email or password");
        }

        var userRole = await _userManager.GetRoleByUserEmailAsync(userByEmail.Email!);
        
        var roleList = new List<string>(userRole);
        var token =  _tokenService.GenerateToken(userByEmail.Email!, userRole);
        
        _httpContextAccessor.HttpContext?.Response.Cookies.Append("accessToken", token, new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(5),
            HttpOnly = true,
            IsEssential = true,
            Secure = true,
            SameSite = SameSiteMode.None
        });
        
        return new UserLoginResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "User was logged in successfully!",
            //Token =  token,
            UserId = userByEmail.Id,
            UserRoles = roleList
        };
    }
}