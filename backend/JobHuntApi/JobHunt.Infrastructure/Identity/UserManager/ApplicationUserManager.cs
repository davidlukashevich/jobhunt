using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Identity.UserManager;

public class ApplicationUserManager : IApplicationUserManager
{
    
    private readonly UserManager<User> _userManager;

    public ApplicationUserManager(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> IsUserExists(string email)
    {
        return await _userManager.Users.AnyAsync(u => u.Email == email);
    }

    public async Task<bool> IsPasswordCorrect(string password, string email)
    {
        return await _userManager.CheckPasswordAsync(await _userManager.FindByEmailAsync(email), password);
    }
}