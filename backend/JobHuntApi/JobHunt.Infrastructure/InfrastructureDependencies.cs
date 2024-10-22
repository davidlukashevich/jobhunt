using System.Diagnostics.CodeAnalysis;
using JobHunt.Domain.Interface.Repository;
using JobHunt.Infrastructure.Data;
using JobHunt.Infrastructure.Identity;
using JobHunt.Infrastructure.Identity.UserManager;
using JobHunt.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace JobHunt.Infrastructure;

public static class InfrastructureDependencies
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        services.AddDbContext<JobHuntDbContext>();

        services.AddIdentityCore<User>().AddEntityFrameworkStores<JobHuntDbContext>();

        

        services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IExperienceRepository, ExperienceRepository>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IUniversityRepository, UniversityRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();

        services.AddScoped<IApplicationUserManager, ApplicationUserManager>();
        
        
        return services;
    }
}