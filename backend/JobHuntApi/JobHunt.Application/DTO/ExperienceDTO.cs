namespace JobHunt.Application.DTO;

public class ExperienceDTO
{
    public Guid Id { get; set; }
    public string?  Position { get; set; }
    public string?  CompanyName { get; set; }
    public string?  Responsibility { get; set; }
    public string? WorkFrom  { get; set; }
    public string? Location { get; set; }
    public string? WorkTo { get; set; }
}