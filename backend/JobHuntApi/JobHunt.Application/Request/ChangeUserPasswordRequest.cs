namespace JobHunt.Application.Request;

public class ChangeUserPasswordRequest
{
    public required string  Email { get; set; }
    public required string  CurrentPassword { get; set; }
    public required string  NewPassword { get; set; }
}