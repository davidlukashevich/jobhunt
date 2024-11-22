namespace JobHunt.Application.Response.Job;

public class JobsResponse
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? CompanyName { get; set; }
    public string? City { get; set; }
    public string? OperationMode { get; set; }
    public string? CompanyLogo { get; set; }
    public string? Salary { get; set; }
    public DateTime CreatedAt { get; set; }
}