
using JobHunt.Domain.Models;


namespace JobHunt.Application.Mapper;

public static class ImageMapper
{
    public static Image ToImageModelCreate( string fileName,string imageName )
    {
        return new Image()
        {
            Id = Guid.NewGuid(),
            Name = fileName,
            ImageUrl = $"https://jobhuntstorage.blob.core.windows.net/images/{imageName}_{fileName}",
        };
    }

    public static Image ToImageModelUpdate(string fileName, string imageName)
    {
        return new Image()
        {
            Name = fileName,
            ImageUrl = $"https://jobhuntstorage.blob.core.windows.net/images/{imageName}_{fileName}",
        };
    }
}
