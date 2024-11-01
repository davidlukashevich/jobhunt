using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.BlobStorage.Files;

public interface IFileService
{
    Task UploadCvAsync(IFormFile file, string containerName);
}