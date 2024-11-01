namespace JobHunt.Application.Request.User;

public class ChangeUserPasswordRequest
{
    public required string  Email { get; set; }
    public required string  CurrentPassword { get; set; }
    public required string  NewPassword { get; set; }
}