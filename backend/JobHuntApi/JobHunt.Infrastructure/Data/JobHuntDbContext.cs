using System.Reflection;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Identity;
using JobHunt.Infrastructure.Interceptors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JobHunt.Infrastructure.Data;

public class JobHuntDbContext
    : IdentityDbContext<User, IdentityRole, string>
{
   

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("Host = jhposgresql.postgres.database.azure.com;  Database=jobhuntdb; Username=postgres; Password=JobHunt_Db-4002; Include Error Detail=true")
            .AddInterceptors(new AuditableInterceptor())
            .EnableSensitiveDataLogging();
        
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        builder.Entity<IdentityUserLogin<string>>().HasNoKey();
        builder.Entity<IdentityUserToken<string>>().HasNoKey();
        
    }
}