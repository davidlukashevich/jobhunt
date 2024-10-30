namespace JobHunt.Domain.Models;

public class Image : BaseEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    //public Guid JobId { get; set; }
}