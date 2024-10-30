namespace JobHunt.Domain.Models;

public class JobApplication : BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public  string? Phone { get; set; }
    public string? AboutInformation { get; set; }
    public string? Cv { get; set; }
    public Guid JobId { get; set; }
}