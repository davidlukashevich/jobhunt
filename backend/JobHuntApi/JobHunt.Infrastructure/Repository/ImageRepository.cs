using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JobHunt.Infrastructure.Repository;

public class ImageRepository : IImageRepository
{
    
    private readonly JobHuntDbContext _context;

    public ImageRepository(JobHuntDbContext context)
    {
        _context = context;
    }

    public async Task CreateImageAsync(Image image)
    {
        await _context.Images.AddAsync(image);
        
        await _context.SaveChangesAsync();
    }

    public async Task UpdateImageAsync(Image image, Guid imageId)
    {
        await _context.Images
            .Where(i => i.Id == imageId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(i => i.Name, image.Name)
                .SetProperty(i => i.ImageUrl, image.ImageUrl)
            );
    }

    public async Task DeleteImageAsync(Guid imageId)
    {
        await _context.Images
            .Where(i => i.Id == imageId)
            .ExecuteDeleteAsync();
    }

    public async Task<Image> GetImageByIdAsync(Guid imageId)
    {
        return (await _context.Images
            .AsNoTracking()
            .FirstOrDefaultAsync(i => i.Id == imageId))!;
    }
}