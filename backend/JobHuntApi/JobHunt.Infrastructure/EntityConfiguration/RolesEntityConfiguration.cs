using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class RolesEntityConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole<string>{ Id = "1", Name = Domain.Enums.Roles.Employer.ToString(), NormalizedName = "EMPLOYER" },
            new IdentityRole<string>{Id =  "2",  Name = Domain.Enums.Roles.Employee.ToString(), NormalizedName = "EMPLOYEE" }
        );
    }
}