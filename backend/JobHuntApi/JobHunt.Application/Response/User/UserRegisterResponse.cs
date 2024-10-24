namespace JobHunt.Application.Response.User;

public class UserRegisterResponse : BaseResponse
{
    public string? Id  { get; set; }
    public string? Token { get; set; }
}