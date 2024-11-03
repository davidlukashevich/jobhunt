using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses");
        
        builder.HasKey(k => k.Id);

        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Country).IsRequired().HasColumnName("country");
        builder.Property(p => p.City).IsRequired().HasColumnName("city");
        builder.Property(p => p.Street).IsRequired().HasColumnName("street");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");

        builder.HasData(
            new List<Address>()
            { 
                new Address { Id = Guid.Parse("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), Country = "Poland", City = "Warsaw", Street = "Krakowskie Przedmieście 10" },
                new Address { Id = Guid.Parse("525c49eb-3406-4210-9125-6085e59b4eb3"), Country = "Poland", City = "Kraków", Street = "Floriańska 15" },
                new Address { Id = Guid.Parse("81829923-f40e-4f58-9506-08da478058a2"), Country = "Poland", City = "Gdańsk", Street = "Dluga 20" },
                new Address { Id = Guid.Parse("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), Country = "Poland", City = "Wrocław", Street = "Rynek 5" },
                new Address { Id = Guid.Parse("65997657-6342-4461-991e-d9ef4cc27808"), Country = "Poland", City = "Poznań", Street = "Święty Marcin 45" },
                new Address { Id = Guid.Parse("c4d716dc-e536-4f93-affd-1eca9be155f1"), Country = "Poland", City = "Łódź", Street = "Piotrkowska 31" },
                new Address { Id = Guid.Parse("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), Country = "Poland", City = "Lublin", Street = "Krakowskie Przedmieście 2" },
                new Address { Id = Guid.Parse("eb0bf179-2a90-42f2-a778-0457f10280b7"), Country = "Poland", City = "Katowice", Street = "3 Maja 9" },
                new Address { Id = Guid.Parse("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), Country = "Poland", City = "Bydgoszcz", Street = "Gdańska 14" },
                new Address { Id = Guid.Parse("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), Country = "Poland", City = "Szczecin", Street = "Aleja Wyzwolenia 21" },
                new Address { Id = Guid.Parse("61e53104-cc1e-4403-b781-ac2a9d90a675"), Country = "Poland", City = "Gdynia", Street = "Świętojańska 6" },
                new Address { Id = Guid.Parse("d1977ab7-eef3-4def-ae48-66f65922b471"), Country = "Poland", City = "Toruń", Street = "Rynek Staromiejski 3" },
                new Address { Id = Guid.Parse("a538082d-1000-4b50-b6ea-7e0f8b715c14"), Country = "Poland", City = "Opole", Street = "Krakowska 7" },
                new Address { Id = Guid.Parse("bc05e016-1537-41f6-80b3-9bbf991dd39c"), Country = "Poland", City = "Rzeszów", Street = "3 Maja 12" },
                new Address { Id = Guid.Parse("3a55e504-11f1-4c82-8628-692982996558"), Country = "Poland", City = "Białystok", Street = "Lipowa 15" },
                new Address { Id = Guid.Parse("9c654eec-ba66-40a6-8bf7-160591a9a602"), Country = "Poland", City = "Zielona Góra", Street = "Bohaterów Westerplatte 10" },
                new Address { Id = Guid.Parse("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), Country = "Poland", City = "Gliwice", Street = "Zwycięstwa 22" },
                new Address { Id = Guid.Parse("6270749d-0b30-4e83-8374-12d23c22271a"), Country = "Poland", City = "Sopot", Street = "Monte Cassino 25" },
                new Address { Id = Guid.Parse("868f8731-4a07-44fd-bd27-4acb4a35f77f"), Country = "Poland", City = "Koszalin", Street = "Zwycięstwa 5" },
                new Address { Id = Guid.Parse("4b23304a-d75c-4dff-8b86-402a8656f39c"), Country = "Poland", City = "Radom", Street = "Żeromskiego 16" },
               
            }
        );


    }
}