using JobHunt.Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace JobHunt.Application.SingInManager;

public class ApplicationSignInManager : IApplicationSignInManager
{
    
    private readonly SignInManager<User> _signInManager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ApplicationSignInManager(SignInManager<User> signInManager, IHttpContextAccessor httpContextAccessor)
    {
        _signInManager = signInManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<bool> CheckPasswordSignInAsync(User user, string password)
    {
        var signInResult =  await _signInManager.CheckPasswordSignInAsync(user, password, false);
        
        return signInResult.Succeeded;
    }

    public Task SignOutAsync()
    {
        
        _httpContextAccessor.HttpContext?.Response.Cookies.Append("accessToken", "", new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(-1),
            HttpOnly = true,
            Secure = true,        
            SameSite = SameSiteMode.None
        });
        

        return Task.CompletedTask;
    }
}