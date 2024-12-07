

namespace JobHunt.Domain.Models;

public class Address : BaseEntity
{
    public Guid Id  { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }

    
    
    
    
}