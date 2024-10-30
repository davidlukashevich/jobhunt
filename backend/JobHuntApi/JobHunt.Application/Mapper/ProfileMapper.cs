
using JobHunt.Application.Response.Profile;

namespace JobHunt.Application.Mapper;

public static class ProfileMapper
{
    public static ProfileResponse MapToProfileResponse(this Domain.Models.Profile profile)
    {
        return new ProfileResponse()
        {
            Id = profile.Id,
            Name = profile.Name,
            Lastname = profile.Lastname,
            Email = profile.Email,
            Phone = profile.Phone,
           // Avatar = profile.Avatar,
            DateOfBirth = profile.DateOfBirth,
            Universities = profile.Universities.Select(u => u.ToUniversityDTO()).ToList(),
            Experiences = profile.Experiences.Select(e => e.ToExperienceDto()).ToList(),
            Address = profile.Address.ToAddressDto(),
           
        };
    }
}