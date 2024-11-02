namespace JobHunt.Application.DTO;

public class UniversityDTO
{
    public Guid Id { get; set; }
    public string?  UniversityName { get; set; }
    public string? EducationLevel { get; set; }
    public string?  FieldOfStudy { get; set; }
    public string?  Specialization { get; set; }
    public string? StudyFrom { get; set; } 
    public string? StudyTo { get; set; }
}