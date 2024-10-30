
using JobHunt.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Mapper;

public static class ImageMapper
{
    public static Image ToImageModelCreate( IFormFile file,string imageName )
    {
        return new Image()
        {
            Id = Guid.NewGuid(),
            Name = file.FileName,
            ImageUrl = $"https://jobhuntstorage.blob.core.windows.net/images/{imageName}_{file.FileName}",
        };
    }
}