﻿namespace JobHunt.Domain.Models;

public class Experience
{
    public Guid Id { get; set; }

    public string?  Position { get; set; }
    
    public string?  CompanyName { get; set; }
    
    public string?  Responsibility { get; set; }
    
    public DateTime WorkFrom  { get; set; }

    public DateTime WorkTo { get; set; }

    public Guid UserId { get; set; }
}