

using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.BlobStorage;

public interface IImageService
{
   Task UploadImageAsync(IFormFile file, string userId, string imageName );
   Task DeleteImageAsync(string key);
   
}