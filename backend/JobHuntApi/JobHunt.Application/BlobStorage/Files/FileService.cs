using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.BlobStorage.Files;

public class FileService : IFileService
{
    
    private readonly BlobServiceClient _blobServiceClient;
    private readonly BlobContainerClient _blobContainerClient;

    public FileService(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
        _blobContainerClient = _blobServiceClient.GetBlobContainerClient("files");
    }

    public async Task UploadCvAsync(IFormFile file, Guid fileGuid)
    {

        try
        {
            var filename = $"cv_{fileGuid}_{file.FileName}";
            
            var blob = _blobContainerClient.GetBlobClient(filename);
        
            await blob.UploadAsync(file.OpenReadStream());
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        
      
    }

    public async Task<bool> IsFileExistsAsync(IFormFile file, Guid fileGuid)
    {
        try
        {
            var filename = $"cv_{fileGuid}_{file.FileName}";
            
            var blobClient = _blobContainerClient.GetBlobClient(filename);

            return await blobClient.ExistsAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}