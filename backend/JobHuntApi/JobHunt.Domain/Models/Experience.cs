namespace JobHunt.Domain.Models;

public class Experience : BaseEntity
{
    public Guid Id { get; set; }
    public string?  Position { get; set; }
    public string?  CompanyName { get; set; }
    public string?  Responsibility { get; set; }
    public DateOnly WorkFrom  { get; set; }
    public string? Location { get; set; }
    public DateOnly WorkTo { get; set; }
    public Guid ProfileId { get; set; }
    
    
}