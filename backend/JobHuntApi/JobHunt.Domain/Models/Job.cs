namespace JobHunt.Domain.Models;

public class Job : BaseEntity
{
    public Guid Id  { get; set; }
    public required string Title { get; set; }
    public required string Type { get; set; }
    public required string Technology { get; set; }
    public required string CompanyName { get; set; }
    public required string OperationMode { get; set; }
    public required string ContractType { get; set; }
    public required string AboutCompany { get; set; }
    public required string JobLevel { get; set; }
    public required string Responsibilities { get; set; }
    public required string Requirements { get; set; }
    public required string CreatedBy { get; set; }
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }
    public Guid ImageId { get; set; }
    public Image? Image { get; set; }
    public required string Salary { get; set; }
    public List<JobApplication>? JobApplications { get; set; }
}