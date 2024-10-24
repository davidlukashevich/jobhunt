namespace JobHunt.Application.Response.User;

public class UserChangePasswordError : BaseResponse
{
    public List<string>? Errors { get; set; }
}