using JobHunt.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JobHunt.Application.Extensions;

public static class MigrationsExtension
{
    public static WebApplication ApplyMigrations(this WebApplication app)
    {

        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<JobHuntDbContext>();
        
        context.Database.Migrate();
        
        return app;
    }
}