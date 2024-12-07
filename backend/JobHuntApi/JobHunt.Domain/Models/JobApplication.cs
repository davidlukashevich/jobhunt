

namespace JobHunt.Domain.Models;

public class JobApplication : BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public  string? Phone { get; set; }
    public string? AboutInformation { get; set; }
    public required string Cv { get; set; }
    public Guid JobId { get; set; }
    public required string CreatedBy { get; set; }
    public Job? Job { get; set; }
    public required string Status { get; set; }
}