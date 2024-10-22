using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JobHuntApi.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JobHunt.Application.Service;

public class TokenService :  ITokenService
{
    
    private readonly JwtOptions _jwtOptions;

    public TokenService(IOptions<JwtOptions> jwtOptions)
    {
        _jwtOptions = jwtOptions.Value;
    }

    public string GenerateToken(string email)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));

        var tokenHandler = new JwtSecurityTokenHandler();
        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Email, email)
        };

        var token = new JwtSecurityToken(
           
            claims: claims,
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256),
            expires: DateTime.Now.AddHours(1)
        );
        
        return tokenHandler.WriteToken(token) ;
    }
}