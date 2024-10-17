using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Profile;

public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand>
{
    
    private readonly IProfileRepository _profileRepository;

    public UpdateProfileCommandHandler(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public async Task Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
    {
        var updatedProfile = new Domain.Models.Profile()
        {
            Name = request.UpdateProfileRequest.Name,
            Lastname = request.UpdateProfileRequest.Lastname,
            Email = request.UpdateProfileRequest.Email,
            Phone = request.UpdateProfileRequest.Phone,
            Avatar = request.UpdateProfileRequest.Avatar,
            DateOfBirth = request.UpdateProfileRequest.DateOfBirth,
        };
        
        await _profileRepository.UpdateProfileAsync(updatedProfile, request.ProfileId);
    }
}