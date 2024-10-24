using JobHunt.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace JobHunt.Application.SingInManager;

public class ApplicationSignInManager : IApplicationSignInManager
{
    
    private readonly SignInManager<User> _signInManager;

    public ApplicationSignInManager(SignInManager<User> signInManager)
    {
        _signInManager = signInManager;
    }

    public async Task<bool> CheckPasswordSignInAsync(User user, string password)
    {
        var signInResult =  await _signInManager.CheckPasswordSignInAsync(user, password, false);
        
        return signInResult.Succeeded;
    }
}