using JobHunt.Application.DTO;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Response.Job;

public class SingleJobResponse
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? CompanyName { get; set; }
    public string? OperationMode { get; set; }
    public string? ContractType { get; set; }
    public string? JobLevel { get; set; }
    public List<string>? Responsibilities { get; set; }
    public List<string>? Requirements { get; set; }
    public ImageDTO? Image { get; set; }
    public AddressDTO? Address { get; set; }
    public string? CreatedBy { get; set; }
    public string? AboutCompany { get; set; }
    public string? Salary { get; set; }
}