namespace JobHunt.Application.Request;

public class UpdateUniversityRequest
{
    public string?  UniversityName { get; set; }
    public string? EducationLevel { get; set; }
    public string?  FieldOfStudy { get; set; }
    public string?  Specialization { get; set; }
    public DateTime StudyFrom { get; set; }
    public DateTime StudyTo { get; set; }
}