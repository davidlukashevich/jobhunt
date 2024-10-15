namespace JobHunt.Infrastructure.Identity.UserManager;

public interface IApplicationUserManager
{
    Task<bool> IsUserExists(string email);
    
    Task<bool> IsPasswordCorrect(string password, string email);
}