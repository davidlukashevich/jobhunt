using Microsoft.AspNetCore.Identity;

namespace JobHunt.Infrastructure.Identity;

public class User : IdentityUser
{
    
    public string? FullName  { get; set; }
}