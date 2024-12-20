﻿namespace JobHunt.Application.Response.JobApplication;

public class ProfileJobApplicationsResponse
{
    public Guid Id { get; set; }
    public string? JobTitle { get; set; }
    public string? JobCompanyName { get; set; }
    public string? JobAddressCountry { get; set; }
    public string? JobAddressCity { get; set; }
    public string? JobCompanyLogo { get; set; }
    public string? Status  { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid JobId { get; set; }
    
}