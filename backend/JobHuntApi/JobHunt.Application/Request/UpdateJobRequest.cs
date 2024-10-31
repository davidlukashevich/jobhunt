namespace JobHunt.Application.Request;

public class UpdateJobRequest
{
    public required string Title { get; set; }
    public required string CompanyName { get; set; }
    public required string OperationMode { get; set; }
    public required string ContractType { get; set; }
    public required string JobLevel { get; set; }
    public required string Responsibilities { get; set; }
    public required string Requirements { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public required string Type { get; set; }
    public required string Technology { get; set; }
    public string? CreatedBy { get; set; }
    public Guid AddressId { get; set; }
    public required string AboutCompany { get; set; }
}