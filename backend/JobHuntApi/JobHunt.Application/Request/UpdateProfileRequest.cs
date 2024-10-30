using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Request;

public class UpdateProfileRequest
{
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public string? UserId { get; set; }
    public string? Avatar { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Guid AddressId { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public IFormFile? ProfileImage { get; set; }
}