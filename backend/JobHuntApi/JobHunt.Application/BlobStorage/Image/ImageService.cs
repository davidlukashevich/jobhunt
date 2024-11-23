
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.BlobStorage.Image;

public class ImageService : IImageService
{
    
    private readonly BlobServiceClient _blobServiceClient;
    private readonly BlobContainerClient _blobContainerClient;

    public ImageService(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
        _blobContainerClient = _blobServiceClient.GetBlobContainerClient("images");
    }

    public async Task UploadImageAsync(IFormFile file,  string imageName, string fileName )
    {

        try
        {
            

           var filename = $"{imageName}_{fileName}";
            
            var blob = _blobContainerClient.GetBlobClient(filename);

            var blobHttpHeaders = new BlobHttpHeaders
            {
                ContentType = file.ContentType,
            };
            
            await blob.UploadAsync(file.OpenReadStream(), new BlobUploadOptions
            {
                HttpHeaders = blobHttpHeaders
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new Exception(e.Message);
        }
        
    }

    public async Task DeleteImageAsync(string fileName, string imageName)
    {

        try
        {
            var blobName = $"{imageName}_{fileName}";
        
            await _blobContainerClient.DeleteBlobIfExistsAsync(blobName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
       
    }
}