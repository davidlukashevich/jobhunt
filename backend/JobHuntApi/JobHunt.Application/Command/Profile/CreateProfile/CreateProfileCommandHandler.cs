using System.Net;
using JobHunt.Application.BlobStorage.Image;
using JobHunt.Application.Command.Address.CreateAddress;
using JobHunt.Application.Command.Image.CreateImage;
using JobHunt.Application.Mapper;
//using JobHunt.Application.MessageBroker;
//using JobHunt.Application.MessageBroker.Address.CreateAddress;
using JobHunt.Application.Response;
using JobHunt.Application.Response.Profile;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Profile.CreateProfile;

public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, BaseResponse>
{
    
    private readonly IProfileRepository _profileRepository;
    //private readonly ISendMessage _sendMessage;
    private readonly IImageService _imageService;
    private readonly ISender _sender;

    public CreateProfileCommandHandler(
        IProfileRepository profileRepository,
       // ISendMessage sendMessage,
        IImageService imageService, ISender sender)
    {
        _profileRepository = profileRepository;
        //_sendMessage = sendMessage;
        _imageService = imageService;
        _sender = sender;
    }

    public async Task<BaseResponse> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
    {
        var commandRequest = request.CreateProfileRequest;

        /*var newAddress = new CreateAddress()
        {
            Id = Guid.NewGuid(),
            Country = request.CreateProfileRequest.Country,
            City = request.CreateProfileRequest.City,
            Street = request.CreateProfileRequest.Street,
        };
        
        await _sendMessage.Send(newAddress, cancellationToken);*/

        var newAddress = AddressMapper.ToCreateAddressRequest(commandRequest.Country!, commandRequest.City!, commandRequest.Street!);
        
        var newProfileLogo = ImageMapper.ToImageModelCreate(commandRequest.ProfileImage.FileName, "profile");
        
        var newProfile = ProfileMapper.ToProfileModelCreate(commandRequest, newAddress.Id, newProfileLogo.Id);
        
        await _sender.Send(new CreateAddressCommand(newAddress), cancellationToken);

        await _sender.Send(new CreateImageCommand(newProfileLogo), cancellationToken);
        
        await _imageService.UploadImageAsync(commandRequest.ProfileImage, "profile", commandRequest.ProfileImage.FileName);
        
        await _profileRepository.CreateProfileAsync(newProfile);

        return new ProfileCreatedResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Profile was created successfully!",
            ProfileId = newProfile.Id
        };
    }
}