
using JobHunt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunt.Infrastructure.EntityConfiguration;

public class JobEntityConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.ToTable("jobs");
        
        builder.HasKey(k => k.Id);

        builder.Property(p => p.Id).HasColumnName("id");
        builder.Property(p => p.Title).HasColumnName("title").IsRequired();
        builder.Property(p => p.CompanyName).HasColumnName("company_name").IsRequired();
        builder.Property(p => p.ContractType).HasColumnName("contract_type").IsRequired();
        builder.Property(p => p.JobLevel).HasColumnName("job_level").IsRequired();
        builder.Property(p => p.Responsibilities).HasColumnName("responsibilities").IsRequired();
        builder.Property(p => p.Requirements).HasColumnName("requirements").IsRequired();
        builder.Property(p => p.AddressId).HasColumnName("address_id").IsRequired();
        builder.Property(p => p.OperationMode).HasColumnName("operation_mode").IsRequired();
        builder.Property(p => p.Type).HasColumnName("type").IsRequired();
        builder.Property(p => p.Technology).HasColumnName("technology").IsRequired();
        builder.Property(p => p.CreatedBy).HasColumnName("created_by").IsRequired();
        builder.Property(p => p.ImageId).HasColumnName("image_id");
        builder.Property(p => p.CreatedAt).HasColumnName("createdAt");
        builder.Property(p => p.UpdatedAt).HasColumnName("updatedAt");
        builder.Property(p => p.Salary).HasColumnName("salary").IsRequired();
        builder.Property(p => p.AboutCompany).HasColumnName("about_company").IsRequired();
        

        builder
            .HasIndex(j =>  new {  j.Title, j.JobLevel, j.Technology, j.Type })
            .HasMethod("GIN")
            .IsTsVectorExpressionIndex("english");


        builder
            .HasOne<Address>(j => j.Address)
            .WithOne()
            .HasForeignKey<Job>(j => j.AddressId);
            
        

        builder
            .HasOne<Image>(j => j.Image)
            .WithOne()
            .HasForeignKey<Job>(j => j.ImageId);

        builder
            .HasMany(j => j.JobApplications)
            .WithOne(ja => ja.Job)
            .HasForeignKey(j => j.JobId);

        builder.HasData(
            new List<Job>()
            {
                
                //frontend
                new Job
                {
                    Id = Guid.NewGuid(),
                    Title = "Junior Frontend Developer",
                    CompanyName = "Code Factory",
                    OperationMode = "Remote",
                    ContractType = "UOP", 
                    JobLevel = "Junior", 
                    Responsibilities = "Assist in frontend dev",
                    Requirements = "1+ years in HTML/CSS, Javascript, React",
                    AboutCompany = "Web and mobile dev",
                    Type = "Frontend", 
                    Technology = "Js", 
                    CreatedBy = "f948c6b6-2651-4cf5-a4ae-a2046511989d",
                    AddressId = Guid.Parse("81829923-f40e-4f58-9506-08da478058a2") ,
                    ImageId = Guid.Parse("b7a18197-c6d6-47c4-ab72-d3a042b646c3"),
                    Salary = "4000-5000 zł brutto"
                    
                },
                new Job
                {
                    Id = Guid.NewGuid(),
                    Title = "Middle Frontend Developer",
                    CompanyName = "Web Wonders",
                    OperationMode = "Hybrid", 
                    ContractType = "UOP", 
                    JobLevel = "Middle", 
                    Responsibilities = "Develop frontend apps", 
                    Requirements = "3+ years with Angular, TypeScript", 
                    AboutCompany = "Web innovation leaders",
                    Type = "Frontend", 
                    Technology = "Typescript",
                    CreatedBy = "f948c6b6-2651-4cf5-a4ae-a2046511989d",
                    AddressId = Guid.Parse("760b41f0-1ae8-4140-aeaa-c51edb8524dd"),
                    ImageId = Guid.Parse("47219591-466c-4f33-bd2e-4b165844b4da"),
                    Salary = "6000-8000 zł brutto"
                },
                
                 new Job
                 {
                     Id = Guid.NewGuid(),
                     Title = "Senior Frontend Developer",
                     CompanyName = "Tech Innovators",
                     OperationMode = "Remote", 
                     ContractType = "B2B", 
                     JobLevel = "Senior", 
                     Responsibilities = "Develop UI components, optimize for performance",
                     Requirements = "5+ years experience with React", 
                     AboutCompany = "Leading in AI solutions", 
                     Type = "Frontend", 
                     Technology = "React", 
                     CreatedBy = "f948c6b6-2651-4cf5-a4ae-a2046511989d",
                     AddressId = Guid.Parse("0ca4032a-b0c0-4d25-8575-f5b065d7df54"),
                     ImageId = Guid.Parse("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"),
                     Salary = "10000-12000 zł netto"
                 },
                 
                 new Job
                 {
                     Id = Guid.NewGuid(), 
                     Title = "Lead Frontend Engineer",
                     CompanyName = "WebWorks", 
                     OperationMode = "Hybrid", 
                     ContractType = "B2B",
                     JobLevel = "Lead",
                     Responsibilities = "Oversee frontend projects", 
                     Requirements = "7+ years with React, javascript, html, css",
                     AboutCompany = "Web dev specialists", 
                     Type = "Frontend", 
                     Technology = "Js",
                     CreatedBy = "f948c6b6-2651-4cf5-a4ae-a2046511989d",
                     AddressId =  Guid.Parse("525c49eb-3406-4210-9125-6085e59b4eb3"),
                     ImageId = Guid.Parse("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"),
                     Salary = "15000-20000 zł netto"
                 },
                 
                
                 
                 //backend
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Junior Backend Developer", 
                CompanyName = "DataX Solutions",
                OperationMode = "Hybrid", 
                ContractType = "B2B", 
                JobLevel = "Junior",
                Responsibilities = "Assist backend development team",
                Requirements = "1+ years with .NET",
                AboutCompany = "Focus on data analytics", 
                Type = "Backend", 
                Technology = ".Net", 
                CreatedBy = "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633",
                AddressId = Guid.Parse("65997657-6342-4461-991e-d9ef4cc27808"),
                ImageId = Guid.Parse("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"),
                Salary = "5000-6000 zł netto"
            },
            
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Middle Backend Developer",
                CompanyName = "DataScience Co",
                OperationMode = "Remote",
                ContractType = "UOP", 
                JobLevel = "Middle", 
                Responsibilities = "Develop API services",
                Requirements = "3+ years with Python, Flask",
                AboutCompany = "Data science leaders", 
                Type = "Backend", 
                Technology = "Python", 
                CreatedBy = "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633",
                AddressId = Guid.Parse("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"),
                ImageId =  Guid.Parse("5f890acc-9532-4c56-9e3c-07a45a91dc83"),
                Salary = "7000-9000 zł brutto"
            },
            
            new Job
            {
                Id = Guid.NewGuid(), 
                Title = "Senior Backend Engineer", 
                CompanyName = "Cloudify", 
                OperationMode = "Remote", 
                ContractType = "B2B", 
                JobLevel = "Senior",
                Responsibilities = "Design backend services",
                Requirements = "5+ years in backend dev, Python, Django",
                AboutCompany = "Experts in cloud tech", 
                Type = "Backend", 
                Technology = "Python", 
                CreatedBy = "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633",
                AddressId = Guid.Parse("c4d716dc-e536-4f93-affd-1eca9be155f1"),
                ImageId = Guid.Parse("239b185c-4d37-4b01-baba-001b4425794a"),
                Salary = "12000-15000 zł netto"
            },
            
            
            
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Lead Backend Developer",
                CompanyName = "CoreTech", 
                OperationMode = "Onsite", 
                ContractType = "UOP", 
                JobLevel = "Lead", 
                Responsibilities = "Lead backend projects", 
                Requirements = "7+ years in backend dev, Java, Spring Boot", 
                AboutCompany = "Backend solutions", 
                Type = "Backend", 
                Technology = "Java", 
                CreatedBy = "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633",
                AddressId = Guid.Parse("eb0bf179-2a90-42f2-a778-0457f10280b7"),
                ImageId = Guid.Parse("caa67e3a-d380-4a7f-9921-bce41d768349"),
                Salary = "15000-20000 zł brutto"
            },
            
            //fullstack
            
            new Job
            {
                Id = Guid.NewGuid(), 
                Title = "Junior Fullstack Developer", 
                CompanyName = "WebGen", 
                OperationMode = "Remote",
                ContractType = "UOP",
                JobLevel = "Junior", 
                Responsibilities = "Support web projects", 
                Requirements = "Experience with HTML, CSS, JavaScript", 
                AboutCompany = "Web innovation hub", 
                Type = "Fullstack", 
                Technology = "Js", 
                CreatedBy = "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d",
                AddressId = Guid.Parse("61e53104-cc1e-4403-b781-ac2a9d90a675"),
                ImageId = Guid.Parse("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"),
                Salary = "4000-5000 zł brutto"
            },
            new Job
            {
                Id = Guid.NewGuid(), 
                Title = "Middle Fullstack Developer", 
                CompanyName = "App Builders", 
                OperationMode = "Remote", 
                ContractType = "B2B", 
                JobLevel = "Middle",
                Responsibilities = "Develop web applications",
                Requirements = "3+ years with JS & Node",
                AboutCompany = "Web solutions specialists", 
                Type = "Fullstack", 
                Technology = "Js",
                CreatedBy = "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d",
                AddressId = Guid.Parse("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"),
                ImageId = Guid.Parse("0c97833d-79fb-43d9-a1e1-25032d81ad77"),
                Salary = "7000-9000 zł netto"
            },
            
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Senior Fullstack Developer", 
                CompanyName = "DigitalCraft",
                OperationMode = "Hybrid",
                ContractType = "UOP",
                JobLevel = "Senior", 
                Responsibilities = "Develop fullstack apps",
                Requirements = "5+ years in fullstack dev, , Ruby on Rails, JavaScript", 
                AboutCompany = "Comprehensive IT services", 
                Type = "Fullstack",
                Technology = "JavaScript", 
                CreatedBy = "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d",
                AddressId = Guid.Parse("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"),
                ImageId = Guid.Parse("f884c7f8-502a-49a6-acde-7350a412b097"),
                Salary = "11000-14000 zł brutto"
            },
            
           
            
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Lead Fullstack Developer",
                CompanyName = "Total Solutions", 
                OperationMode = "Remote", 
                ContractType = "UOP", 
                JobLevel = "Lead",
                Responsibilities = "Lead fullstack projects",
                Requirements = "7+ years in fullstack dev, JavaScript, Node.js, React",
                AboutCompany = "IT and web solutions",
                Type = "Fullstack", 
                Technology = "Javascript", 
                CreatedBy = "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d",
                AddressId = Guid.Parse("d1977ab7-eef3-4def-ae48-66f65922b471"),
                ImageId = Guid.Parse("01761843-a4d3-4dbd-988b-977094f0a083"),
                Salary = "16000-19000 zł brutto"
            },
            
            //mobile
            new Job
            {
                Id = Guid.NewGuid(), 
                Title = "Junior Mobile Developer",
                CompanyName = "AppLab", 
                OperationMode = "Onsite", 
                ContractType = "B2B",
                JobLevel = "Junior", 
                Responsibilities = "Support mobile dev team", 
                Requirements = "Basic knowledge in Swift, iOS",
                AboutCompany = "Creative app developers", 
                Type = "Mobile",
                Technology = "Swift", 
                CreatedBy = "b2cdded4-83f2-41da-ad9f-8feed8e0c300",
                AddressId = Guid.Parse("bc05e016-1537-41f6-80b3-9bbf991dd39c"),
                ImageId = Guid.Parse("39fd3f9a-1911-4676-b4cf-d245f68a83a7"),
                Salary = "7000-9000 zł netto"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Title = " Middle Mobile Developer", 
                CompanyName = "NextGen Mobile",
                OperationMode = "Hybrid",
                ContractType = "B2B", 
                JobLevel = "Middle",
                Responsibilities = "Maintain mobile apps", 
                Requirements = "2+ years in mobile dev, Kotlin",
                AboutCompany = "Mobile app innovation", 
                Type = "Mobile", 
                Technology =  "Kotlin", 
                CreatedBy = "b2cdded4-83f2-41da-ad9f-8feed8e0c300",
                AddressId = Guid.Parse("a538082d-1000-4b50-b6ea-7e0f8b715c14"),
                ImageId = Guid.Parse("ba513f10-c72d-4cdb-a105-d6b462ec61fe"),
                Salary = "10000-13000 zł netto"
            },
            
           
          
            new Job
            {
                Id = Guid.NewGuid(), 
                Title = "Senior Mobile Developer",
                CompanyName = "MobiSolutions", 
                OperationMode = "Hybrid", 
                ContractType = "UOP", 
                JobLevel = "Senior", 
                Responsibilities = "Design mobile features", 
                Requirements = "5+ years in mobile dev, , Android, Kotlin",
                AboutCompany = "Top mobile solutions", 
                Type = "Mobile", 
                Technology = "Kotlin",
                CreatedBy = "b2cdded4-83f2-41da-ad9f-8feed8e0c300",
                AddressId = Guid.Parse("3a55e504-11f1-4c82-8628-692982996558"),
                ImageId = Guid.Parse("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"),
                Salary = "15000-20000 zł brutto"
            },
            
            
            new Job
            {
                Id = Guid.NewGuid(), 
                Title = "Lead Mobile Developer", 
                CompanyName = "AppSphere",
                OperationMode = "Onsite", 
                ContractType = "UOP", 
                JobLevel = "Lead", 
                Responsibilities = "Oversee mobile development",
                Requirements = "7+ years in mobile dev, Swift",
                AboutCompany = "Specializing in mobile tech", 
                Type = "Mobile", 
                Technology = "Swift", 
                CreatedBy = "b2cdded4-83f2-41da-ad9f-8feed8e0c300",
                AddressId = Guid.Parse("9c654eec-ba66-40a6-8bf7-160591a9a602"),
                ImageId = Guid.Parse("aa697543-3225-4e7b-8baf-83d71683b2c8"),
                Salary = "20000-25000 zł brutto"
            },
           
            
            //gamedev
            
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Junior Game Developer",
                CompanyName = "PlayMax Studios",
                OperationMode = "Remote",
                ContractType = "B2B",
                JobLevel = "Junior",
                Responsibilities = "Write game mechanics code",
                Requirements = "Experience with Unity, C#",
                AboutCompany = "Renowned in game dev", 
                Type = "GameDev", 
                Technology = "C#", 
                CreatedBy = "b2cdded4-83f2-41da-ad9f-8feed8e0c300",
                AddressId = Guid.Parse("6270749d-0b30-4e83-8374-12d23c22271a"),
                ImageId = Guid.Parse("32bafe62-e9ba-4c2a-9f2a-76053c689eff"),
                Salary = "8000-9000 zł netto"
            },
            new Job
            {
                Id = Guid.NewGuid(),
                Title = "Middle Game Developer",
                CompanyName = "GameForge",
                OperationMode = "Onsite",
                ContractType = "UOP", 
                JobLevel = "Middle", 
                Responsibilities = "Create engaging game logic", 
                Requirements = "3+ years with Unity,C#",
                AboutCompany = "Innovators in gaming", 
                Type = "Gamedev", 
                Technology = "C#",
                CreatedBy = "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d",
                AddressId = Guid.Parse("5f6ec67a-de91-4260-a1cf-50aebeb8181b"),
                ImageId = Guid.Parse("a7bcaf46-c806-4bf4-825f-e17852cd276c"),
                Salary = "10000-12000 zł brutto"
            },
            
           

            new Job 
            { 
                Id = Guid.NewGuid(), 
                Title = "Senior Game Developer", 
                CompanyName = "PlayMax Studios", 
                OperationMode = "Remote", 
                ContractType = "UOP", 
                JobLevel = "Senior", 
                Responsibilities = "Develop complex game systems, mentor junior developers", 
                Requirements = "5+ years with Unity or Unreal Engine, strong C# or C++ skills", 
                AboutCompany = "A renowned leader in AAA game development", 
                Type = "GameDev", 
                Technology = "C#", 
                CreatedBy = "f948c6b6-2651-4cf5-a4ae-a2046511989d" ,
                AddressId = Guid.Parse("868f8731-4a07-44fd-bd27-4acb4a35f77f"),
                ImageId = Guid.Parse("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"),
                Salary = "14000-17000 zł brutto"
            },
            new Job 
            { 
                Id = Guid.NewGuid(), 
                Title = "Lead Game Developer", 
                CompanyName = "Epic Games Studio", 
                OperationMode = "Onsite", 
                ContractType = "UOP", 
                JobLevel = "Lead", 
                Responsibilities = "Lead the game development team, oversee project lifecycle", 
                Requirements = "7+ years in game development, experience leading large projects, Unreal Engine, C++, Game Design", 
                AboutCompany = "Industry leader in immersive gaming experiences", 
                Type = "GameDev", 
                Technology = "C++", 
                CreatedBy = "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633" ,
                AddressId = Guid.Parse("4b23304a-d75c-4dff-8b86-402a8656f39c"),
                ImageId = Guid.Parse("d86c3bf1-22f9-467a-bb25-a335508074c2"),
                Salary = "18000-20000 zł brutto"
            }
            
            }
        );

    }
}