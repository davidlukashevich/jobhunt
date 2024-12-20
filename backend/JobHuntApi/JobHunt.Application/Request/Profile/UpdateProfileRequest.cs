﻿using JobHunt.Application.DTO;
using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Request.Profile;

public class UpdateProfileRequest
{
    public required string Name { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public required string Specialization { get; set; }
    public required string ProfileSummary { get; set; }
    public string? Phone { get; set; }
    public string? UserId { get; set; }
    public int DateOfBirthYear { get; set; }
    public int DateOfBirthMonth { get; set; }
    public int DateOfBirthDay { get; set; }
    public Guid AddressId { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public IFormFile? ProfileImage { get; set; }
    public Guid ProfileImageId { get; set; }
}