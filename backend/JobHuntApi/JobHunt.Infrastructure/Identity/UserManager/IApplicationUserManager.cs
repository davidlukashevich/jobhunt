using Microsoft.AspNetCore.Identity;

namespace JobHunt.Infrastructure.Identity.UserManager;

public interface IApplicationUserManager
{
    Task<bool> IsUserExistsAsync(string email);
    Task<bool> IsPasswordCorrectAsync(string password, string email);
    Task<IdentityResult> ChangeUserPasswordAsync(User user, string currentPassword, string newPassword);
    Task<IdentityResult> RegisterUserAsync(User user, string password);
    Task<User> FindByEmailAsync(string email);
    
}