using System.Net;
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.Response;
using JobHunt.Application.Response.Profile;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Profile.CreateProfile;

public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, BaseResponse>
{
    
    private readonly IProfileRepository _profileRepository;
    private readonly ISendMessage _sendMessage;

    public CreateProfileCommandHandler(IProfileRepository profileRepository, ISendMessage sendMessage)
    {
        _profileRepository = profileRepository;
        _sendMessage = sendMessage;
    }

    public async Task<BaseResponse> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
    {

        var newAddress = new CreateAddress()
        {
            Id = Guid.NewGuid(),
            Country = request.CreateProfileRequest.Country,
            City = request.CreateProfileRequest.City,
            Street = request.CreateProfileRequest.Street,
        };
        
        await _sendMessage.Send(newAddress, cancellationToken);
        
        var newProfile = new Domain.Models.Profile()
        {
            Id = Guid.NewGuid(),
            Name = request.CreateProfileRequest.Name,
            Lastname = request.CreateProfileRequest.Lastname,
            Email = request.CreateProfileRequest.Email,
            Phone = request.CreateProfileRequest.Phone,
            Avatar = request.CreateProfileRequest.Avatar,
            DateOfBirth = request.CreateProfileRequest.DateOfBirth,
            AddressId = newAddress.Id,
        };
        
        await _profileRepository.CreateProfileAsync(newProfile);

        return new ProfileCreatedResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Profile was  created",
            ProfileId = newProfile.Id
        };
    }
}