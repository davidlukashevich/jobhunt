using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Image.UpdateImage;

public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand>
{
    
    private readonly IImageRepository _imageRepository;

    public UpdateImageCommandHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }

    public async Task Handle(UpdateImageCommand request, CancellationToken cancellationToken)
    {
        await _imageRepository.UpdateImageAsync(request.Image, request.ImageId);
    }
}