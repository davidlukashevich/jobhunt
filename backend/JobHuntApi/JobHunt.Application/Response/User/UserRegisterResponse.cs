namespace JobHunt.Application.Response.User;

public class UserRegisterResponse : BaseResponse
{
    public string? Token { get; set; }
    public string? UserId { get; set; }
    public List<string>? UserRoles { get; set; }
}