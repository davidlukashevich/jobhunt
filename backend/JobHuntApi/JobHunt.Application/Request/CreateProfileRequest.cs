using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Request;

public class CreateProfileRequest
{
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public IFormFile File { get; set; }
    public string UserId { get; set; }
}