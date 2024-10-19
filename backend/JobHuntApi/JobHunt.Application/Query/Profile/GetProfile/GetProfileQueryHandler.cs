using JobHunt.Application.Mapper.Profile;
using JobHunt.Application.Response.Profile;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Profile.GetProfile;

public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, ProfileResponse>
{
    
    private readonly IProfileRepository _profileRepository;

    public GetProfileQueryHandler(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public async Task<ProfileResponse> Handle(GetProfileQuery request, CancellationToken cancellationToken)
    {
        var profile = await _profileRepository.GetProfileAsync(request.Id);

        return profile!.MapToProfileResponse();
    }
}