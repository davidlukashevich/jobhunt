using JobHunt.Application.DTO;

namespace JobHunt.Application.Request.Experience;

public class CreateExperienceRequest
{
    public string?  Position { get; set; }
    public string?  CompanyName { get; set; }
    public string?  Responsibility { get; set; }
    public DateDto? WorkFrom  { get; set; }
    public string? Location { get; set; }
    public DateDto? WorkTo { get; set; }
}