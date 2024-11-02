using JobHunt.Application.DTO;

namespace JobHunt.Application.Request.University;

public class CreateUniversityRequest
{
    public string?  UniversityName { get; set; }
    public string? EducationLevel { get; set; }
    public string?  FieldOfStudy { get; set; }
    public string?  Specialization { get; set; }
    public DateDto? StudyFrom { get; set; }
    public DateDto? StudyTo { get; set; }
}