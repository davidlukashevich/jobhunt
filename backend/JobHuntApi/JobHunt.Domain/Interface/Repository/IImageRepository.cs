using JobHunt.Domain.Models;

namespace JobHunt.Domain.Interface.Repository;

public interface IImageRepository
{
    Task CreateImageAsync(Image image);
    Task UpdateImageAsync(Image image, Guid imageId);
    Task DeleteImageAsync(Guid imageId);
    Task<Image> GetImageByIdAsync(Guid imageId);
}