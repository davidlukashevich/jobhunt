namespace JobHunt.Application.Service;

public interface ITokenService
{
    string GenerateToken(string email, IList<string> roles);
}