using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Image.DeleteImage;

public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand>
{
    private readonly IImageRepository _imageRepository;

    public DeleteImageCommandHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }

    public async Task Handle(DeleteImageCommand request, CancellationToken cancellationToken)
    {
        await _imageRepository.DeleteImageAsync(request.ImageId);
    }
}