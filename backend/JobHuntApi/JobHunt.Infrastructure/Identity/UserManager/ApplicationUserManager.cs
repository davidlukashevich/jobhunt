using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Identity.UserManager;

public class ApplicationUserManager : IApplicationUserManager
{
    
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    

    public ApplicationUserManager(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
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

    public async Task<IdentityResult> RegisterUserAsync(User user,  string password, string role)
    {
        
        var isRoleExist = await _roleManager.RoleExistsAsync(role);

        if (!isRoleExist)
        {
            return IdentityResult.Failed();
        }
        
        await _userManager.AddToRoleAsync(user, role);
        
        return  await _userManager.CreateAsync(user, password) ;
            
        
    }

    public Task<User?> FindByEmailAsync(string email)
    {
        return _userManager.FindByEmailAsync(email);
    }

    public async Task<IList<string>> GetRoleByUserEmailAsync(string email)
    {
        var roles =  await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(email));
        
        return  roles;
    }

    
}