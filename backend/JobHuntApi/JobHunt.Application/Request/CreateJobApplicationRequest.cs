using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Request;

public class CreateJobApplicationRequest
{
    public required string Firstname  { get; set; }
    public required string Lastname  { get; set; }
    public required string Email  { get; set; }
    public string? Mobile  { get; set; }
    public string? AboutUser  { get; set; }
    public IFormFile?  Cv  { get; set; }
    public Guid JobId { get; set; }
    public required string CreatedBy { get; set; }
}