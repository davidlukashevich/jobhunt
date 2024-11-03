

using JobHunt.Application;
using JobHunt.Application.Extensions;
using JobHunt.Application.Options;
using JobHunt.Infrastructure;


using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var services = builder.Services;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));


builder.Services
    .AddApplication(configuration)
    .AddInfrastructure();

services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});





builder.Services.AddCors(options =>
{
    options.AddPolicy("JobHuntClientApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000");
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
        policy.AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseExceptionHandler(_ => { });

app.UseHttpsRedirection();

app.UseCors("JobHuntClientApp");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();