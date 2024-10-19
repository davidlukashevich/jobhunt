namespace JobHunt.Application.Request;

public class CreateProfileRequest
{
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public string? Avatar { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
}