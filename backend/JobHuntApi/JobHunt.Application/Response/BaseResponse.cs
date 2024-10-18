using System.Net;

namespace JobHunt.Application.Response;

public class BaseResponse
{
    public HttpStatusCode StatusCode { get; set; }
    public string? Message { get; set; }
}