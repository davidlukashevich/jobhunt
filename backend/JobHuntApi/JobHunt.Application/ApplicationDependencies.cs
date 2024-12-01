
using System.Text;
using Azure.Storage.Blobs;
using JobHunt.Application.BlobStorage.Files;
using JobHunt.Application.BlobStorage.Image;
using JobHunt.Application.Exceptions;
using JobHunt.Application.Service;
using JobHunt.Application.SingInManager;
using JobHunt.Infrastructure.Data;
using JobHunt.Infrastructure.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;


namespace JobHunt.Application;

public static class ApplicationDependencies
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {

        services
            .AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<JobHuntDbContext>()
            .AddDefaultTokenProviders();
        
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        });
        
        services.AddHttpContextAccessor();

        services.AddSingleton(_ =>  new BlobServiceClient(configuration.GetConnectionString("BlobStorage")) );
        services.AddScoped<IImageService, ImageService>();
        services.AddScoped<IFileService, FileService>();
       // services.AddScoped<ISendMessage, SendMessage>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IApplicationSignInManager, ApplicationSignInManager>();
        services.AddScoped<IRoleStore<IdentityRole>, RoleStore<IdentityRole, JobHuntDbContext>>();
        services.AddScoped<IUserStore<IdentityUser>, UserStore<IdentityUser, IdentityRole, JobHuntDbContext>>();

        services.AddExceptionHandler<GlobalException>();

        /*
        services.AddMassTransit(x =>
        {
            
            x.AddConsumer<CreateAddressConsumer>();
            x.AddConsumer<UpdateAddressConsumer>();
            x.AddConsumer<DeleteAddressConsumer>();
            
            x.UsingRabbitMq((ctx, cfg) =>
            {
                cfg.Host("rabbitmq://localhost", o =>
                {
                    o.Username("guest");
                    o.Password("guest");
                });
                
                cfg.ReceiveEndpoint("create-address", e =>
                {
                    e.ConfigureConsumer<CreateAddressConsumer>(ctx);
                });
                
                cfg.ReceiveEndpoint("update-address", e =>
                {
                    e.ConfigureConsumer<UpdateAddressConsumer>(ctx);
                });
                
                cfg.ReceiveEndpoint("delete-address", e =>
                {
                    e.ConfigureConsumer<DeleteAddressConsumer>(ctx);
                });
            });
        });
        */

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(jwt =>
        {
            jwt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtOptions:Key"]!))
            };

            jwt.Events = new JwtBearerEvents
            {
                OnMessageReceived = ctx =>
                { 
                    ctx.Request.Cookies.TryGetValue("accessToken", out var accessToken);

                    if (!string.IsNullOrEmpty(accessToken))
                    {
                        ctx.Token = accessToken;
                    }
                    
                    return Task.CompletedTask;
                }
            };
        });

        services.AddAuthorization(options =>
        {
            options.AddPolicy("RequireEmployerRole", policy =>
            {
                policy.RequireRole("Employer");
            });
            
            options.AddPolicy("RequireEmployeeRole", policy =>
            {
                policy.RequireRole("Employee");
            });
        });
        
        
        
        
        
        return services;
    }
}