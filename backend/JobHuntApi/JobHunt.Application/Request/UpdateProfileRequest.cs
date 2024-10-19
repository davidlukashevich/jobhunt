namespace JobHunt.Application.Request;

public class UpdateProfileRequest
{
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public string? Avatar { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Guid AddressId { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
}