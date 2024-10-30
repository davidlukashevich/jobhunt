

using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.BlobStorage;

public interface IImageService
{
   Task UploadImageAsync(IFormFile file,  string imageName );
   Task DeleteImageAsync(string key);
   
}