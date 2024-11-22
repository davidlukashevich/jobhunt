using MediatR;

namespace JobHunt.Application.Response.JobApplication;

public class JobApplicationsByJobIdResponse
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Lastname { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public DateTime CreatedAt { get; set; }
}
