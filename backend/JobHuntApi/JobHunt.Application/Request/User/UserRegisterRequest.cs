namespace JobHunt.Application.Request.User;

public class UserRegisterRequest
{
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Username { get; set; }
    public required string Role { get; set; }
}