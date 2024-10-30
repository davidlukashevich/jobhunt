using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Image.CreateImage;

public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand>
{
    
    private readonly IImageRepository _imageRepository;

    public CreateImageCommandHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }

    public async Task Handle(CreateImageCommand request, CancellationToken cancellationToken)
    {
        await _imageRepository.CreateImageAsync(request.Image);
    }
}