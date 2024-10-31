using System.Net;
using JobHunt.Application.BlobStorage;
using JobHunt.Application.Command.Address.UpdateAddress;
using JobHunt.Application.Command.Image.UpdateImage;
using JobHunt.Application.Mapper;
//using JobHunt.Application.MessageBroker;
//using JobHunt.Application.MessageBroker.Address.UpdateAddress;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Profile.UpdateProfile;

public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, BaseResponse>
{
    
    private readonly IProfileRepository _profileRepository;
    private readonly ISender _sender;
    private readonly IImageService _imageService;
    //private readonly ISendMessage _sendMessage;

    public UpdateProfileCommandHandler(
        IProfileRepository profileRepository, 
        ISender sender, IImageService imageService
        //ISendMessage sendMessage
        )
    {
        _profileRepository = profileRepository;
        _sender = sender;
        _imageService = imageService;
        //_sendMessage = sendMessage;
    }

    public async Task<BaseResponse> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
    {
        
        
        /*var updatedAddress = new UpdateAddress()
        {
            Id = request.UpdateProfileRequest.AddressId,
            Country = request.UpdateProfileRequest.Country,
            City = request.UpdateProfileRequest.City,
            Street = request.UpdateProfileRequest.Street,
        };
        
        await _sendMessage.Send(updatedAddress, cancellationToken);*/

        var updatedProfileRequest = request.UpdateProfileRequest;

        var updatedAddressRequest = AddressMapper.ToUpdateAddressRequest(
            updatedProfileRequest.City, 
            updatedProfileRequest.Country,
            updatedProfileRequest.Street);

        await _sender.Send(new UpdateAddressCommand(
            updatedProfileRequest.AddressId,
            updatedAddressRequest), 
            cancellationToken);

        if (updatedProfileRequest.ProfileImage is not null)
        {
            await _imageService.UploadImageAsync(
                updatedProfileRequest.ProfileImage,
                "profile", 
                request.ProfileId.ToString()
                );

            var updatedImageProfile = ImageMapper.ToImageModelUpdate(
                request.ProfileId.ToString(),
                "profile");

            await _sender.Send(new UpdateImageCommand(
                    updatedProfileRequest.ProfileImageId, 
                    updatedImageProfile),
                    cancellationToken
                    );


        }
                
                

        var updatedProfile = ProfileMapper.ToProfileModelUpdate(updatedProfileRequest);

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
            Message = "Profile was updated successfully!",
        };
    }
}