namespace JobHunt.Application.Service;

public interface ITokenService
{
    string GenerateToken(string email);
}