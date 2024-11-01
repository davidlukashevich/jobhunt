using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class ImageEntityConfiguration : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.ToTable("images");
        builder.HasKey(k => k.Id);
        
        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Name).HasColumnName("name").IsRequired();
        builder.Property(p => p.ImageUrl).HasColumnName("image_url").IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("createdAt");
        builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt");


        builder.HasData(
            new List<Image>
            {
                new Image(){Id = Guid.Parse("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), Name = "jfd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/jfd.jpg"},
                new Image(){Id = Guid.Parse("47219591-466c-4f33-bd2e-4b165844b4da"), Name = "mfd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/mfd.jpg"},
                new Image(){Id = Guid.Parse("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), Name = "sfd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/sfd.png"},
                new Image(){Id = Guid.Parse("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), Name = "lfd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/lfd.png"},
                new Image(){Id = Guid.Parse("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), Name = "jbd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/jbd.jpg"},
                new Image(){Id = Guid.Parse("5f890acc-9532-4c56-9e3c-07a45a91dc83"), Name = "mbd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/mbd.jpg"},
                new Image(){Id = Guid.Parse("239b185c-4d37-4b01-baba-001b4425794a"), Name = "sbd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/sbd.png"},
                new Image(){Id = Guid.Parse("caa67e3a-d380-4a7f-9921-bce41d768349"), Name = "lbd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/lbd.png"},
                new Image(){Id = Guid.Parse("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), Name = "jfld.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/jfld.png"},
                new Image(){Id = Guid.Parse("0c97833d-79fb-43d9-a1e1-25032d81ad77"), Name = "mfld.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/mfld.png"},
                new Image(){Id = Guid.Parse("f884c7f8-502a-49a6-acde-7350a412b097"), Name = "sfld.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/sfld.png"},
                new Image(){Id = Guid.Parse("01761843-a4d3-4dbd-988b-977094f0a083"), Name = "lfld.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/lfld.png"},
                new Image(){Id = Guid.Parse("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), Name = "jgd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/jgd.jpg"},
                new Image(){Id = Guid.Parse("a7bcaf46-c806-4bf4-825f-e17852cd276c"), Name = "mgd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/mgd.jpg"},
                new Image(){Id = Guid.Parse("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), Name = "sgd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/sgd.jpg"},
                new Image(){Id = Guid.Parse("d86c3bf1-22f9-467a-bb25-a335508074c2"), Name = "lgd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/lgd.png"},
                new Image(){Id = Guid.Parse("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), Name = "jmd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/jmd.png"},
                new Image(){Id = Guid.Parse("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), Name = "mmd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/mmd.png"},
                new Image(){Id = Guid.Parse("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), Name = "smd.jpg",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/smd.jpg"},
                new Image(){Id = Guid.Parse("aa697543-3225-4e7b-8baf-83d71683b2c8"), Name = "lmd.png",ImageUrl = "https://jobhuntstorage.blob.core.windows.net/images/lmd.png"},
            }
        );

    }
}