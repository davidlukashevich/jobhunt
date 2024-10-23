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

    public async Task<bool> IsUserExistsAsync(string email)
    {
        return await _userManager.Users.AnyAsync(u => u.Email == email);
    }

    public async Task<bool> IsPasswordCorrectAsync(string password, string email)
    {
        return await _userManager.CheckPasswordAsync(await _userManager.FindByEmailAsync(email), password);
    }

    public async Task<IdentityResult> ChangeUserPasswordAsync(User user, string currentPassword, string newPassword)
    {
        return await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
        
        
    }

    public async Task<IdentityResult> RegisterUserAsync(User user,  string password)
    {
        return await _userManager
            
            .CreateAsync(user, password);
    }

    public Task<User> FindByEmailAsync(string email)
    {
        return _userManager.FindByEmailAsync(email);
    }
}