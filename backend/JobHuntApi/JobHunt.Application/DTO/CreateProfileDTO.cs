using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.DTO;

public class CreateProfileDTO
{
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public required string Specialization { get; set; }
    public required string ProfileSummary { get; set; }
    public string? Phone { get; set; }
    public int DateOfBirthYear { get; set; }
    public int DateOfBirthMonth { get; set; }
    public int DateOfBirthDay { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public IFormFile? File { get; set; }
    public string? UserId { get; set; }
}