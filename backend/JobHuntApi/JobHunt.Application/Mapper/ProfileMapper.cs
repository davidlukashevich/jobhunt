
using JobHunt.Application.Request;
using JobHunt.Application.Response.Profile;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class ProfileMapper
{
    public static ProfileResponse MapToProfileResponse(this Profile profile)
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
            Universities = profile.Universities?.Select(u => u.ToUniversityDTO()).ToList(),
            Experiences = profile.Experiences?.Select(e => e.ToExperienceDto()).ToList(),
            Address = profile.Address!.ToAddressDto(),
           
        };
    }

    public static Profile ToProfileModelCreate(CreateProfileRequest request, Guid addressId)
    {
        return new Profile()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Lastname = request.Lastname,
            Email = request.Email,
            Phone = request.Phone,
            ProfileImage = $"https://jobhuntstorage.blob.core.windows.net/images/profile_{request.UserId}{Path.GetExtension(request.File.FileName)}",
            DateOfBirth = request.DateOfBirth,
            AddressId = addressId,
            CreatedBy = request.UserId,
            
            
        };
    }

    public static Profile ToProfileModelUpdate(UpdateProfileRequest request)
    {
        return new Profile()
        {
            Name = request.Name,
            Lastname = request.Lastname,
            Email = request.Email,
            Phone = request.Phone,
            ProfileImage = request.Avatar,
            DateOfBirth = request.DateOfBirth,
            CreatedBy = request.UserId,
        };
    }
}