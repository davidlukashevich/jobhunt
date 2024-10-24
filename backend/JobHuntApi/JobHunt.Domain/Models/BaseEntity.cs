using JobHunt.Domain.Interface;

namespace JobHunt.Domain.Models;

public class BaseEntity : IBaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}