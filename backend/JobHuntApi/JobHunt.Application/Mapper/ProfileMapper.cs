
using JobHunt.Application.DTO;
using JobHunt.Application.Request.Profile;
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
            DateOfBirth = new DateOnly(profile.DateOfBirth.Year, profile.DateOfBirth.Month, profile.DateOfBirth.Day).ToString("dd/MM/yyyy"),
            Universities = profile.Universities?.Select(u => u.ToUniversityDTO()).ToList(),
            Experiences = profile.Experiences?.Select(e => e.ToExperienceDto()).ToList(),
            Address = profile.Address!.ToAddressDto(),
            Image = new ImageDTO()
            {
                Id = profile.Image.Id,
                ImageUrl = profile.Image.ImageUrl,
            }
           
        };
    }

    public static Profile ToProfileModelCreate(CreateProfileRequest request, Guid addressId, Guid imageId)
    {
        return new Profile()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Lastname = request.Lastname,
            Email = request.Email,
            Phone = request.Phone,
            DateOfBirth = new DateOnly(request.DateOfBirthYear, request.DateOfBirthMonth, request.DateOfBirthDay),
            AddressId = addressId,
            CreatedBy = request.UserId,
            ImageId = imageId,
            
            
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
            //ProfileImage = request.Avatar,
            DateOfBirth = new DateOnly(request.DateOfBirthYear, request.DateOfBirthMonth, request.DateOfBirthDay),
            CreatedBy = request.UserId,
        };
    }
}