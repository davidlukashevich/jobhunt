﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingtestdatatotables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "id", "city", "country", "createdAt", "street", "updatedAt" },
                values: new object[,]
                {
                    { new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), "Lublin", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krakowskie Przedmieście 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), "Warsaw", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krakowskie Przedmieście 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a55e504-11f1-4c82-8628-692982996558"), "Białystok", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lipowa 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"), "Radom", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Żeromskiego 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"), "Kraków", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floriańska 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), "Gliwice", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zwycięstwa 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"), "Gdynia", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Świętojańska 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6270749d-0b30-4e83-8374-12d23c22271a"), "Sopot", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monte Cassino 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65997657-6342-4461-991e-d9ef4cc27808"), "Poznań", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Święty Marcin 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), "Bydgoszcz", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gdańska 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), "Wrocław", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rynek 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81829923-f40e-4f58-9506-08da478058a2"), "Gdańsk", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dluga 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"), "Koszalin", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zwycięstwa 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"), "Zielona Góra", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bohaterów Westerplatte 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"), "Opole", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krakowska 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), "Szczecin", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aleja Wyzwolenia 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"), "Rzeszów", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Maja 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"), "Łódź", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piotrkowska 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"), "Toruń", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rynek Staromiejski 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"), "Katowice", "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Maja 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "createdAt", "image_url", "name", "updatedAt" },
                values: new object[,]
                {
                    { new Guid("01761843-a4d3-4dbd-988b-977094f0a083"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/lfld.png", "lfld.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/mfld.png", "mfld.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/sgd.jpg", "sgd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("239b185c-4d37-4b01-baba-001b4425794a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/sbd.png", "sbd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/jgd.jpg", "jgd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/jmd.png", "jmd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47219591-466c-4f33-bd2e-4b165844b4da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/mfd.jpg", "mfd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/mbd.jpg", "mbd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/jbd.jpg", "jbd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/smd.jpg", "smd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/sfd.png", "sfd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/mgd.jpg", "mgd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/lmd.png", "lmd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/jfd.jpg", "jfd.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/jfld.png", "jfld.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/mmd.png", "mmd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/lbd.png", "lbd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/lgd.png", "lgd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f884c7f8-502a-49a6-acde-7350a412b097"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/sfld.png", "sfld.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://jobhuntstorage.blob.core.windows.net/images/lfd.png", "lfd.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "id", "about_company", "address_id", "company_name", "contract_type", "createdAt", "created_by", "image_id", "job_level", "operation_mode", "requirements", "responsibilities", "technology", "title", "type", "updatedAt" },
                values: new object[,]
                {
                    { new Guid("23d9e44c-b903-4488-9e3b-7eefab1becfe"), "Web innovation hub", new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"), "WebGen", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), "Junior", "Remote", "Experience with HTML, CSS, JavaScript", "Support web projects", "Js", "Junior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("335fe048-ee18-4960-97a2-95e8ea6bcb5b"), "Web and mobile dev", new Guid("81829923-f40e-4f58-9506-08da478058a2"), "Code Factory", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), "Junior", "Remote", "1+ years in HTML/CSS, Javascript, React", "Assist in frontend dev", "Js", "Junior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c1d7aa6-d68c-4534-90a6-6603f65243be"), "Leading in AI solutions", new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), "Tech Innovators", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), "Senior", "Remote", "5+ years experience with React", "Develop UI components, optimize for performance", "React", "Senior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43b6d933-d0a8-438b-ac43-e033acaa8978"), "Web innovation leaders", new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), "Web Wonders", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("47219591-466c-4f33-bd2e-4b165844b4da"), "Middle", "Hybrid", "3+ years with Angular, TypeScript", "Develop frontend apps", "Typescript", "Middle Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f85d20e-acfe-4ac6-9021-75137c1ccb1d"), "Focus on data analytics", new Guid("65997657-6342-4461-991e-d9ef4cc27808"), "DataX Solutions", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), "Junior", "Hybrid", "1+ years with .NET", "Assist backend development team", ".Net", "Junior Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("519d680e-c05f-45c2-bcc9-1af7feaf8f1f"), "A renowned leader in AAA game development", new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"), "PlayMax Studios", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), "Senior", "Remote", "5+ years with Unity or Unreal Engine, strong C# or C++ skills", "Develop complex game systems, mentor junior developers", "C#", "Senior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56da99a8-6ca3-404f-bbe6-25ed809866df"), "Web dev specialists", new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"), "WebWorks", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), "Lead", "Hybrid", "7+ years with React, javascript, html, css", "Oversee frontend projects", "Js", "Lead Frontend Engineer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65409a2a-0cd8-4d9a-bd0c-422fec747a6b"), "IT and web solutions", new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"), "Total Solutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("01761843-a4d3-4dbd-988b-977094f0a083"), "Lead", "Remote", "7+ years in fullstack dev, JavaScript, Node.js, React", "Lead fullstack projects", "Javascript", "Lead Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("693422cd-f6b3-4590-ba66-f5473124b06b"), "Web solutions specialists", new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), "App Builders", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"), "Middle", "Remote", "3+ years with JS & Node", "Develop web applications", "Js", "Middle Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("708fb34c-2286-4176-9342-5d642fb3cf47"), "Comprehensive IT services", new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), "DigitalCraft", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("f884c7f8-502a-49a6-acde-7350a412b097"), "Senior", "Hybrid", "5+ years in fullstack dev, , Ruby on Rails, JavaScript", "Develop fullstack apps", "JavaScript", "Senior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71e38101-6b1a-45da-80bf-7075b398c745"), "Top mobile solutions", new Guid("3a55e504-11f1-4c82-8628-692982996558"), "MobiSolutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), "Senior", "Hybrid", "5+ years in mobile dev, , Android, Kotlin", "Design mobile features", "Kotlin", "Senior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83fdfce0-e580-4ca9-b954-555bd7c14536"), "Creative app developers", new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"), "AppLab", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), "Junior", "Onsite", "Basic knowledge in Swift, iOS", "Support mobile dev team", "Swift", "Junior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("872b12c2-3c2f-41d2-acd8-00e103c0ccee"), "Data science leaders", new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), "DataScience Co", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"), "Middle", "Remote", "3+ years with Python, Flask", "Develop API services", "Python", "Middle Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88041c82-a0b2-4214-90c5-e34b5a4cf64e"), "Backend solutions", new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"), "CoreTech", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"), "Lead", "Onsite", "7+ years in backend dev, Java, Spring Boot", "Lead backend projects", "Java", "Lead Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8831bc31-a93a-4015-ab30-c9743eb3f267"), "Innovators in gaming", new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), "GameForge", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"), "Middle", "Onsite", "3+ years with Unity,C#", "Create engaging game logic", "C#", "Middle Game Developer", "Gamedev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac3bed56-f571-4c0b-9436-24b140a62ad5"), "Experts in cloud tech", new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"), "Cloudify", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("239b185c-4d37-4b01-baba-001b4425794a"), "Senior", "Remote", "5+ years in backend dev, Python, Django", "Design backend services", "Python", "Senior Backend Engineer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7e375ba-7452-4c67-8a70-bac20182ef2c"), "Specializing in mobile tech", new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"), "AppSphere", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"), "Lead", "Onsite", "7+ years in mobile dev, Swift", "Oversee mobile development", "Swift", "Lead Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7522cdd-708d-4098-9db7-932d59a77ec7"), "Mobile app innovation", new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"), "NextGen Mobile", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), "Middle", "Hybrid", "2+ years in mobile dev, Kotlin", "Maintain mobile apps", "Kotlin", " Middle Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5a92cb4-61cf-4b3c-86bb-272d41d8b760"), "Renowned in game dev", new Guid("6270749d-0b30-4e83-8374-12d23c22271a"), "PlayMax Studios", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), "Junior", "Remote", "Experience with Unity, C#", "Write game mechanics code", "C#", "Junior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7bf7250-4b46-4d1a-8c9b-e7c77bda3c8f"), "Industry leader in immersive gaming experiences", new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"), "Epic Games Studio", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"), "Lead", "Onsite", "7+ years in game development, experience leading large projects, Unreal Engine, C++, Game Design", "Lead the game development team, oversee project lifecycle", "C++", "Lead Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("23d9e44c-b903-4488-9e3b-7eefab1becfe"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("335fe048-ee18-4960-97a2-95e8ea6bcb5b"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("3c1d7aa6-d68c-4534-90a6-6603f65243be"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("43b6d933-d0a8-438b-ac43-e033acaa8978"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("4f85d20e-acfe-4ac6-9021-75137c1ccb1d"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("519d680e-c05f-45c2-bcc9-1af7feaf8f1f"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("56da99a8-6ca3-404f-bbe6-25ed809866df"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("65409a2a-0cd8-4d9a-bd0c-422fec747a6b"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("693422cd-f6b3-4590-ba66-f5473124b06b"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("708fb34c-2286-4176-9342-5d642fb3cf47"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("71e38101-6b1a-45da-80bf-7075b398c745"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("83fdfce0-e580-4ca9-b954-555bd7c14536"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("872b12c2-3c2f-41d2-acd8-00e103c0ccee"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("88041c82-a0b2-4214-90c5-e34b5a4cf64e"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("8831bc31-a93a-4015-ab30-c9743eb3f267"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("ac3bed56-f571-4c0b-9436-24b140a62ad5"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("c7e375ba-7452-4c67-8a70-bac20182ef2c"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("d7522cdd-708d-4098-9db7-932d59a77ec7"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("e5a92cb4-61cf-4b3c-86bb-272d41d8b760"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("f7bf7250-4b46-4d1a-8c9b-e7c77bda3c8f"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("3a55e504-11f1-4c82-8628-692982996558"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("6270749d-0b30-4e83-8374-12d23c22271a"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("65997657-6342-4461-991e-d9ef4cc27808"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("81829923-f40e-4f58-9506-08da478058a2"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("01761843-a4d3-4dbd-988b-977094f0a083"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("239b185c-4d37-4b01-baba-001b4425794a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("47219591-466c-4f33-bd2e-4b165844b4da"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f884c7f8-502a-49a6-acde-7350a412b097"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"));
        }
    }
}