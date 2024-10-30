
using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using JobHunt.Infrastructure.Identity.UserManager;
using JobHunt.Infrastructure.Repository;

using Microsoft.Extensions.DependencyInjection;


namespace JobHunt.Infrastructure;

public static class InfrastructureDependencies
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        services.AddDbContext<JobHuntDbContext>();

        
        
        services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IExperienceRepository, ExperienceRepository>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IUniversityRepository, UniversityRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IApplicationUserManager, ApplicationUserManager>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
        
        
        return services;
    }
}