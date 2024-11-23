namespace JobHunt.Domain.Models;

public class Profile : BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public required string Specialization { get; set; }
    public required string ProfileSummary { get; set; }
    public string? Phone { get; set; }
    public  string? CreatedBy  { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public List<University>? Universities { get; set; }
    public List<Experience>? Experiences { get; set; }
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }
    public Guid ImageId { get; set; }
    public Image Image { get; set; }
    


}