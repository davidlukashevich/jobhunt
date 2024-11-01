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

    public async Task UploadCvAsync(IFormFile file, string containerName)
    {

        try
        {
            var filename = $"cv_{file.FileName}";
        
            var blob = _blobContainerClient.GetBlobClient(filename);
        
            await blob.UploadAsync(file.OpenReadStream());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        
      
    }
}