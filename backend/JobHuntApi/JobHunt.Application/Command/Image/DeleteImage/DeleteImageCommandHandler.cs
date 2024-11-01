using JobHunt.Application.BlobStorage.Image;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Image.DeleteImage;

public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand>
{
    private readonly IImageRepository _imageRepository;
    private readonly IImageService _imageService;

    public DeleteImageCommandHandler(IImageRepository imageRepository, IImageService imageService)
    {
        _imageRepository = imageRepository;
        _imageService = imageService;
    }

    public async Task Handle(DeleteImageCommand request, CancellationToken cancellationToken)
    {

        var imageById = await _imageRepository.GetImageByIdAsync(request.ImageId);

        await _imageService.DeleteImageAsync(imageById.Name!, "job");
        
        await _imageRepository.DeleteImageAsync(request.ImageId);
    }
}