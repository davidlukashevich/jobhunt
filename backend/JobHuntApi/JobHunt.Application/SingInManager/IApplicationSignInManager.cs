using JobHunt.Infrastructure.Identity;

namespace JobHunt.Application.SingInManager;

public interface IApplicationSignInManager
{
    Task<bool> CheckPasswordSignInAsync(User user, string password);
    Task SignOutAsync();
    
}