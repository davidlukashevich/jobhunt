using JobHunt.Application.DTO;

namespace JobHunt.Application.Response.Profile;

public class ProfileResponse
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public string? Avatar { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<UniversityDTO>? Universities { get; set; }
    public List<ExperienceDTO>? Experiences { get; set; }
    public AddressDTO? Address { get; set; }
}