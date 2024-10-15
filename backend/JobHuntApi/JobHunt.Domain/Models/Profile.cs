namespace JobHunt.Domain.Models;

public class Profile
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Lastname { get; set; }

    public required string Email { get; set; }

    public string? Phone { get; set; }
    
    public string? Avatar { get; set; }

    public DateTime DateOfBirth { get; set; }


}