using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Request.Job;

public class CreateJobRequest
{
    public required string Title { get; set; }
    public required string CompanyName { get; set; }
    public required string OperationMode { get; set; }
    public required string ContractType { get; set; }
    public required string JobLevel { get; set; }
    public required List<string> Responsibilities { get; set; }
    public required List<string> Requirements { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public IFormFile? File { get; set; }
    public required string Type { get; set; }
    public required string Technology { get; set; }
    public required string CreatedBy { get; set; }
    public required string AboutCompany { get; set; }
    public required string Salary { get; set; }
}