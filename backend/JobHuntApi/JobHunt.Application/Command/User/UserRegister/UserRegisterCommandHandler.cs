using System.Net;
using JobHunt.Application.Exceptions.User;
using JobHunt.Application.Response.User;
using JobHunt.Application.Service;
using JobHunt.Infrastructure.Identity.UserManager;
using MediatR;
using Microsoft.AspNetCore.Http;


namespace JobHunt.Application.Command.User.UserRegister;

public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, UserRegisterResponse>
{
    
    private readonly IApplicationUserManager _applicationUserManager;
    private readonly ITokenService _tokenService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserRegisterCommandHandler(IApplicationUserManager applicationUserManager, ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
    {
        _applicationUserManager = applicationUserManager;
        _tokenService = tokenService;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<UserRegisterResponse> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        var userByEmail = await _applicationUserManager.IsUserExistsAsync(request.UserRegisterRequest.Email);

        if (userByEmail)
        {
            
            throw new UserExistsException("User with this email already exists");
            
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
        
        _httpContextAccessor.HttpContext?.Response.Cookies.Append("accessToken", token, new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(5),
            HttpOnly = true,
            IsEssential = true,
            Secure = true,
            SameSite = SameSiteMode.None
        });
        
        return new UserRegisterResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "User has been registered successfully!",
            //Token = token,
            UserId = newUser.Id,
            UserRoles = roleList
        };
    }
}