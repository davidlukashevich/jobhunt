using System.Net;
using JobHunt.Application.MessageBroker;
using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Profile.UpdateProfile;

public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, BaseResponse>
{
    
    private readonly IProfileRepository _profileRepository;
    private readonly ISendMessage _sendMessage;

    public UpdateProfileCommandHandler(IProfileRepository profileRepository, ISendMessage sendMessage)
    {
        _profileRepository = profileRepository;
        _sendMessage = sendMessage;
    }

    public async Task<BaseResponse> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
    {

        var updatedAddress = new UpdateAddress()
        {
            Id = request.UpdateProfileRequest.AddressId,
            Country = request.UpdateProfileRequest.Country,
            City = request.UpdateProfileRequest.City,
            Street = request.UpdateProfileRequest.Street,
        };
        
        await _sendMessage.Send(updatedAddress, cancellationToken);
        
        var updatedProfile = new Domain.Models.Profile()
        {
            Name = request.UpdateProfileRequest.Name,
            Lastname = request.UpdateProfileRequest.Lastname,
            Email = request.UpdateProfileRequest.Email,
            Phone = request.UpdateProfileRequest.Phone,
            Avatar = request.UpdateProfileRequest.Avatar,
            DateOfBirth = request.UpdateProfileRequest.DateOfBirth,
            CreatedBy = request.UpdateProfileRequest.UserId!,
            
        };

        if (!await _profileRepository.UpdateProfileAsync(updatedProfile, request.ProfileId))
        {
            return new BaseResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "Error updating profile"
            };
        }
        
        

        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Profile was updated",
        };
    }
}