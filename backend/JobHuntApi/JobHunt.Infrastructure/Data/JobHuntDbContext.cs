using System.Reflection;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace JobHunt.Infrastructure.Data;

public class JobHuntDbContext(DbContextOptions<JobHuntDbContext> options)
    : IdentityDbContext<User, IdentityRole, string>(options)
{
   

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }


    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("")
            .AddInterceptors(new AuditableInterceptor())
            .EnableSensitiveDataLogging();
        
    }*/
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        builder.Entity<IdentityUserLogin<string>>().HasNoKey();
        builder.Entity<IdentityUserToken<string>>().HasNoKey();
        
    }
}