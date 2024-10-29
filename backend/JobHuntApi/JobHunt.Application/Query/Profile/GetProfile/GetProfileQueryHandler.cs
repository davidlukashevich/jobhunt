using JobHunt.Application.Mapper;
using JobHunt.Application.Response.Profile;
using JobHunt.Domain.Interface.Repository;
using JobHunt.Application.BlobStorage;
using MediatR;

namespace JobHunt.Application.Query.Profile.GetProfile;

public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, ProfileResponse>
{
    
    private readonly IProfileRepository _profileRepository;
    private readonly IImageService _imageService;

    public GetProfileQueryHandler(IProfileRepository profileRepository, IImageService imageService)
    {
        _profileRepository = profileRepository;
        _imageService = imageService;
    }

    public async Task<ProfileResponse> Handle(GetProfileQuery request, CancellationToken cancellationToken)
    {
        var profile = await _profileRepository.GetProfileAsync(request.UserId);

        

        return profile!.MapToProfileResponse();
    }
}