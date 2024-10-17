namespace JobHunt.Application.Request;

public class UpdateExperienceRequest
{
    public string?  Position { get; set; }
    public string?  CompanyName { get; set; }
    public string?  Responsibility { get; set; }
    public string? Location { get; set; }
    public DateTime WorkFrom  { get; set; }
    public DateTime WorkTo { get; set; }
}