namespace JobHunt.Application.Response.User;

public class UserLoginResponse : BaseResponse
{
    public  string? Token { get; set; }
    public string? UserId { get; set; }
}