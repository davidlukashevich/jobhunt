using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Query.Image.GetImageById;

public class GetImageByIdQueryHandler : IRequestHandler<GetImageByIdQuery, Domain.Models.Image>
{
    
    private readonly IImageRepository _imageRepository;

    public GetImageByIdQueryHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }

    public async Task<Domain.Models.Image> Handle(GetImageByIdQuery request, CancellationToken cancellationToken)
    {
        return await _imageRepository.GetImageByIdAsync(request.Id);
    }
}