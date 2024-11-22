using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingstatuscolumntojobapplicationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("02052c90-4f85-469b-a6dd-0143e80cc688"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("116a86e2-4d69-42c1-b0dc-44777f218daa"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("11e54c47-9a04-4584-a523-20fb7909d067"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("15213a54-0e96-475a-b93d-70b4e91a23bd"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("2f4f1f5e-7d70-4bfa-ba52-55a0655d1b66"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("2f9e3626-08a3-4d9c-90d4-101f9e58287c"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("3bc88c56-6eef-480f-a940-18bd21ddba27"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("46a7218b-8b76-4fba-92fd-a1ea61380da8"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("4e78f3c6-ba66-425d-b488-e349435bbc4d"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("58709e94-9ada-4ca8-8f7a-4a076a2ab9ec"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("5b74933d-d06f-4bca-b8d7-b6bebd643e51"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("71cafc82-a482-4055-aba5-55fe616eae39"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("7cdab76b-6e62-4717-a46c-d38c8e590162"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("97444e85-cd7c-4f68-8799-95f3de6b7215"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("b517cc87-5322-4b4d-8d90-a8b839e1a24a"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("bb4e2c5f-2c02-4576-b01e-bd48a362c079"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("bdc15363-aceb-4cf3-bde8-dd5fdd227272"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("c4ddd05a-581e-4be6-9e29-1e8d604e9e38"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("d5a24bff-c85f-4bc3-8708-a0e39bec6aea"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("f37a58b9-5f15-4576-ab26-a766c1bdaab0"));

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "job_applications",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "id", "about_company", "address_id", "company_name", "contract_type", "created_at", "created_by", "image_id", "job_level", "operation_mode", "requirements", "responsibilities", "salary", "technology", "title", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("03c6f356-9ac0-4f2f-8aa0-bb9adafa556a"), "Experts in cloud tech", new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"), "Cloudify", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("239b185c-4d37-4b01-baba-001b4425794a"), "Senior", "Remote", "[\"5\\u002B years in backend dev, Python, Django\"]", "[\"Design backend services\"]", "12000-15000 zł netto", "Python", "Senior Backend Engineer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a8f1a9b-6e32-4b87-b418-21f848d59856"), "Backend solutions", new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"), "CoreTech", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"), "Lead", "Onsite", "[\"7\\u002B years in backend dev, Java, Spring Boot\"]", "[\"Lead backend projects\"]", "15000-20000 zł brutto", "Java", "Lead Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24ee4f94-dbff-4632-a909-d46a8935f3d6"), "Top mobile solutions", new Guid("3a55e504-11f1-4c82-8628-692982996558"), "MobiSolutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), "Senior", "Hybrid", "[\"5\\u002B years in mobile dev, , Android, Kotlin\"]", "[\"Design mobile features\"]", "15000-20000 zł brutto", "Kotlin", "Senior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("266c1a98-ea78-406e-9d9d-55b3efbd7061"), "A renowned leader in AAA game development", new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"), "PlayMax Studios", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), "Senior", "Remote", "[\"5\\u002B years with Unity or Unreal Engine, strong C# or C\\u002B\\u002B skills\"]", "[\"Develop complex game systems, mentor junior developers\"]", "14000-17000 zł brutto", "C#", "Senior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30d5bbda-c420-4c53-889f-254ba63303c7"), "Web dev specialists", new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"), "WebWorks", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), "Lead", "Hybrid", "[\"7\\u002B years with React, javascript, html, css\"]", "[\"Oversee frontend projects\"]", "15000-20000 zł netto", "Js", "Lead Frontend Engineer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37219d59-c26d-4b70-b1d3-3987a845d6db"), "Comprehensive IT services", new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), "DigitalCraft", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("f884c7f8-502a-49a6-acde-7350a412b097"), "Senior", "Hybrid", "[\"5\\u002B years in fullstack dev, , Ruby on Rails, JavaScript\"]", "[\"Develop fullstack apps\"]", "11000-14000 zł brutto", "JavaScript", "Senior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("378b763b-f612-43f0-a85f-e202143db047"), "Innovators in gaming", new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), "GameForge", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"), "Middle", "Onsite", "[\"3\\u002B years with Unity,C#\"]", "[\"Create engaging game logic\"]", "10000-12000 zł brutto", "C#", "Middle Game Developer", "Gamedev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f8eef7d-8cc2-4e04-9407-6240e8625ed8"), "Web innovation hub", new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"), "WebGen", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), "Junior", "Remote", "[\"Experience with HTML, CSS, JavaScript\"]", "[\"Support web projects\"]", "4000-5000 zł brutto", "Js", "Junior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("714ede8a-d647-4c26-8ce1-a003153d79cb"), "Web innovation leaders", new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), "Web Wonders", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("47219591-466c-4f33-bd2e-4b165844b4da"), "Middle", "Hybrid", "[\"3\\u002B years with Angular, TypeScript\"]", "[\"Develop frontend apps\"]", "6000-8000 zł brutto", "Typescript", "Middle Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81ce8cae-1b35-4b8a-848e-c0b2682a1cc2"), "Focus on data analytics", new Guid("65997657-6342-4461-991e-d9ef4cc27808"), "DataX Solutions", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), "Junior", "Hybrid", "[\"1\\u002B years with .NET\"]", "[\"Assist backend development team\"]", "5000-6000 zł netto", ".Net", "Junior Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a270d46-c65a-4cff-8c5b-07af2db0ff83"), "Mobile app innovation", new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"), "NextGen Mobile", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), "Middle", "Hybrid", "[\"2\\u002B years in mobile dev, Kotlin\"]", "[\"Maintain mobile apps\"]", "10000-13000 zł netto", "Kotlin", " Middle Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad36fa43-66b1-4eda-98a2-878b19dea5f8"), "IT and web solutions", new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"), "Total Solutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("01761843-a4d3-4dbd-988b-977094f0a083"), "Lead", "Remote", "[\"7\\u002B years in fullstack dev, JavaScript, Node.js, React\"]", "[\"Lead fullstack projects\"]", "16000-19000 zł brutto", "Javascript", "Lead Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8866da7-b6e0-4136-b15a-53bca50c8fe6"), "Renowned in game dev", new Guid("6270749d-0b30-4e83-8374-12d23c22271a"), "PlayMax Studios", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), "Junior", "Remote", "[\"Experience with Unity, C#\"]", "[\"Write game mechanics code\"]", "8000-9000 zł netto", "C#", "Junior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb7d2bed-dfc2-48e9-aeec-972c05fb59d3"), "Leading in AI solutions", new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), "Tech Innovators", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), "Senior", "Remote", "[\"5\\u002B years experience with React\"]", "[\"Develop UI components, optimize for performance\"]", "10000-12000 zł netto", "React", "Senior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c01af4a8-35d8-4a0e-b957-414ee7c1d548"), "Web solutions specialists", new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), "App Builders", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"), "Middle", "Remote", "[\"3\\u002B years with JS \\u0026 Node\"]", "[\"Develop web applications\"]", "7000-9000 zł netto", "Js", "Middle Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c112ffbf-bda9-4ed2-8495-bb07ea172911"), "Industry leader in immersive gaming experiences", new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"), "Epic Games Studio", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"), "Lead", "Onsite", "[\"7\\u002B years in game development, experience leading large projects, Unreal Engine, C\\u002B\\u002B, Game Design\"]", "[\"Lead the game development team, oversee project lifecycle\"]", "18000-20000 zł brutto", "C++", "Lead Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d09ceed7-7b8c-4fcf-8c1b-328e36d03039"), "Data science leaders", new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), "DataScience Co", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"), "Middle", "Remote", "[\"3\\u002B years with Python, Flask\"]", "[\"Develop API services\"]", "7000-9000 zł brutto", "Python", "Middle Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9769268-7d47-4079-b022-b53ea8409863"), "Creative app developers", new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"), "AppLab", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), "Junior", "Onsite", "[\"Basic knowledge in Swift, iOS\"]", "[\"Support mobile dev team\"]", "7000-9000 zł netto", "Swift", "Junior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea4e5ff1-0cbd-4b13-b316-f73221153c15"), "Specializing in mobile tech", new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"), "AppSphere", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"), "Lead", "Onsite", "[\"7\\u002B years in mobile dev, Swift\"]", "[\"Oversee mobile development\"]", "20000-25000 zł brutto", "Swift", "Lead Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fcd7d422-1477-428f-8ca2-7b5cd8529e84"), "Web and mobile dev", new Guid("81829923-f40e-4f58-9506-08da478058a2"), "Code Factory", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), "Junior", "Remote", "[\"1\\u002B years in HTML/CSS, Javascript, React\"]", "[\"Assist in frontend dev\"]", "4000-5000 zł brutto", "Js", "Junior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("03c6f356-9ac0-4f2f-8aa0-bb9adafa556a"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("1a8f1a9b-6e32-4b87-b418-21f848d59856"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("24ee4f94-dbff-4632-a909-d46a8935f3d6"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("266c1a98-ea78-406e-9d9d-55b3efbd7061"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("30d5bbda-c420-4c53-889f-254ba63303c7"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("37219d59-c26d-4b70-b1d3-3987a845d6db"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("378b763b-f612-43f0-a85f-e202143db047"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("3f8eef7d-8cc2-4e04-9407-6240e8625ed8"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("714ede8a-d647-4c26-8ce1-a003153d79cb"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("81ce8cae-1b35-4b8a-848e-c0b2682a1cc2"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("8a270d46-c65a-4cff-8c5b-07af2db0ff83"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("ad36fa43-66b1-4eda-98a2-878b19dea5f8"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("b8866da7-b6e0-4136-b15a-53bca50c8fe6"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("bb7d2bed-dfc2-48e9-aeec-972c05fb59d3"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("c01af4a8-35d8-4a0e-b957-414ee7c1d548"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("c112ffbf-bda9-4ed2-8495-bb07ea172911"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("d09ceed7-7b8c-4fcf-8c1b-328e36d03039"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("e9769268-7d47-4079-b022-b53ea8409863"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("ea4e5ff1-0cbd-4b13-b316-f73221153c15"));

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "id",
                keyValue: new Guid("fcd7d422-1477-428f-8ca2-7b5cd8529e84"));

            migrationBuilder.DropColumn(
                name: "status",
                table: "job_applications");

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "id", "about_company", "address_id", "company_name", "contract_type", "created_at", "created_by", "image_id", "job_level", "operation_mode", "requirements", "responsibilities", "salary", "technology", "title", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("02052c90-4f85-469b-a6dd-0143e80cc688"), "Top mobile solutions", new Guid("3a55e504-11f1-4c82-8628-692982996558"), "MobiSolutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("8b9cea71-52d1-46fd-b1e7-b2b54726bfa6"), "Senior", "Hybrid", "5+ years in mobile dev, , Android, Kotlin", "Design mobile features", "15000-20000 zł brutto", "Kotlin", "Senior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("116a86e2-4d69-42c1-b0dc-44777f218daa"), "Web innovation hub", new Guid("61e53104-cc1e-4403-b781-ac2a9d90a675"), "WebGen", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("ba1c1bbf-cd15-49ce-8fcb-d744593c5299"), "Junior", "Remote", "Experience with HTML, CSS, JavaScript", "Support web projects", "4000-5000 zł brutto", "Js", "Junior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11e54c47-9a04-4584-a523-20fb7909d067"), "Specializing in mobile tech", new Guid("9c654eec-ba66-40a6-8bf7-160591a9a602"), "AppSphere", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("aa697543-3225-4e7b-8baf-83d71683b2c8"), "Lead", "Onsite", "7+ years in mobile dev, Swift", "Oversee mobile development", "20000-25000 zł brutto", "Swift", "Lead Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15213a54-0e96-475a-b93d-70b4e91a23bd"), "Web dev specialists", new Guid("525c49eb-3406-4210-9125-6085e59b4eb3"), "WebWorks", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("fc8e5936-d76a-4d3a-bc64-d91d6d6e7da9"), "Lead", "Hybrid", "7+ years with React, javascript, html, css", "Oversee frontend projects", "15000-20000 zł netto", "Js", "Lead Frontend Engineer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f4f1f5e-7d70-4bfa-ba52-55a0655d1b66"), "Focus on data analytics", new Guid("65997657-6342-4461-991e-d9ef4cc27808"), "DataX Solutions", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("7d296ead-d7f2-4f9d-a2d9-f756b0aaa1a4"), "Junior", "Hybrid", "1+ years with .NET", "Assist backend development team", "5000-6000 zł netto", ".Net", "Junior Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f9e3626-08a3-4d9c-90d4-101f9e58287c"), "Web and mobile dev", new Guid("81829923-f40e-4f58-9506-08da478058a2"), "Code Factory", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("b7a18197-c6d6-47c4-ab72-d3a042b646c3"), "Junior", "Remote", "1+ years in HTML/CSS, Javascript, React", "Assist in frontend dev", "4000-5000 zł brutto", "Js", "Junior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bc88c56-6eef-480f-a940-18bd21ddba27"), "IT and web solutions", new Guid("d1977ab7-eef3-4def-ae48-66f65922b471"), "Total Solutions", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("01761843-a4d3-4dbd-988b-977094f0a083"), "Lead", "Remote", "7+ years in fullstack dev, JavaScript, Node.js, React", "Lead fullstack projects", "16000-19000 zł brutto", "Javascript", "Lead Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46a7218b-8b76-4fba-92fd-a1ea61380da8"), "A renowned leader in AAA game development", new Guid("868f8731-4a07-44fd-bd27-4acb4a35f77f"), "PlayMax Studios", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("20deaa5a-9243-4e3d-bed1-dc0a23aaccd3"), "Senior", "Remote", "5+ years with Unity or Unreal Engine, strong C# or C++ skills", "Develop complex game systems, mentor junior developers", "14000-17000 zł brutto", "C#", "Senior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e78f3c6-ba66-425d-b488-e349435bbc4d"), "Mobile app innovation", new Guid("a538082d-1000-4b50-b6ea-7e0f8b715c14"), "NextGen Mobile", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("ba513f10-c72d-4cdb-a105-d6b462ec61fe"), "Middle", "Hybrid", "2+ years in mobile dev, Kotlin", "Maintain mobile apps", "10000-13000 zł netto", "Kotlin", " Middle Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58709e94-9ada-4ca8-8f7a-4a076a2ab9ec"), "Leading in AI solutions", new Guid("0ca4032a-b0c0-4d25-8575-f5b065d7df54"), "Tech Innovators", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("9788b6d6-2dfd-4272-8249-43a66bfc5e2b"), "Senior", "Remote", "5+ years experience with React", "Develop UI components, optimize for performance", "10000-12000 zł netto", "React", "Senior Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b74933d-d06f-4bca-b8d7-b6bebd643e51"), "Web innovation leaders", new Guid("760b41f0-1ae8-4140-aeaa-c51edb8524dd"), "Web Wonders", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948c6b6-2651-4cf5-a4ae-a2046511989d", new Guid("47219591-466c-4f33-bd2e-4b165844b4da"), "Middle", "Hybrid", "3+ years with Angular, TypeScript", "Develop frontend apps", "6000-8000 zł brutto", "Typescript", "Middle Frontend Developer", "Frontend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71cafc82-a482-4055-aba5-55fe616eae39"), "Experts in cloud tech", new Guid("c4d716dc-e536-4f93-affd-1eca9be155f1"), "Cloudify", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("239b185c-4d37-4b01-baba-001b4425794a"), "Senior", "Remote", "5+ years in backend dev, Python, Django", "Design backend services", "12000-15000 zł netto", "Python", "Senior Backend Engineer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7cdab76b-6e62-4717-a46c-d38c8e590162"), "Data science leaders", new Guid("02cb7c97-8ac4-4df1-b9bb-a9ff6732c728"), "DataScience Co", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("5f890acc-9532-4c56-9e3c-07a45a91dc83"), "Middle", "Remote", "3+ years with Python, Flask", "Develop API services", "7000-9000 zł brutto", "Python", "Middle Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97444e85-cd7c-4f68-8799-95f3de6b7215"), "Backend solutions", new Guid("eb0bf179-2a90-42f2-a778-0457f10280b7"), "CoreTech", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("caa67e3a-d380-4a7f-9921-bce41d768349"), "Lead", "Onsite", "7+ years in backend dev, Java, Spring Boot", "Lead backend projects", "15000-20000 zł brutto", "Java", "Lead Backend Developer", "Backend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b517cc87-5322-4b4d-8d90-a8b839e1a24a"), "Comprehensive IT services", new Guid("aecc1bcc-91a9-406c-9258-b38bbd12fdb9"), "DigitalCraft", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("f884c7f8-502a-49a6-acde-7350a412b097"), "Senior", "Hybrid", "5+ years in fullstack dev, , Ruby on Rails, JavaScript", "Develop fullstack apps", "11000-14000 zł brutto", "JavaScript", "Senior Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb4e2c5f-2c02-4576-b01e-bd48a362c079"), "Renowned in game dev", new Guid("6270749d-0b30-4e83-8374-12d23c22271a"), "PlayMax Studios", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("32bafe62-e9ba-4c2a-9f2a-76053c689eff"), "Junior", "Remote", "Experience with Unity, C#", "Write game mechanics code", "8000-9000 zł netto", "C#", "Junior Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bdc15363-aceb-4cf3-bde8-dd5fdd227272"), "Industry leader in immersive gaming experiences", new Guid("4b23304a-d75c-4dff-8b86-402a8656f39c"), "Epic Games Studio", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c5bb0f28-a52d-4c3a-9fec-6e7eb50da633", new Guid("d86c3bf1-22f9-467a-bb25-a335508074c2"), "Lead", "Onsite", "7+ years in game development, experience leading large projects, Unreal Engine, C++, Game Design", "Lead the game development team, oversee project lifecycle", "18000-20000 zł brutto", "C++", "Lead Game Developer", "GameDev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4ddd05a-581e-4be6-9e29-1e8d604e9e38"), "Web solutions specialists", new Guid("6dceaa73-c28e-4aa5-b148-aa673e9b80b5"), "App Builders", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("0c97833d-79fb-43d9-a1e1-25032d81ad77"), "Middle", "Remote", "3+ years with JS & Node", "Develop web applications", "7000-9000 zł netto", "Js", "Middle Fullstack Developer", "Fullstack", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5a24bff-c85f-4bc3-8708-a0e39bec6aea"), "Innovators in gaming", new Guid("5f6ec67a-de91-4260-a1cf-50aebeb8181b"), "GameForge", "UOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ad681aa-e3d3-49b8-be8c-ce8fea3bd62d", new Guid("a7bcaf46-c806-4bf4-825f-e17852cd276c"), "Middle", "Onsite", "3+ years with Unity,C#", "Create engaging game logic", "10000-12000 zł brutto", "C#", "Middle Game Developer", "Gamedev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f37a58b9-5f15-4576-ab26-a766c1bdaab0"), "Creative app developers", new Guid("bc05e016-1537-41f6-80b3-9bbf991dd39c"), "AppLab", "B2B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b2cdded4-83f2-41da-ad9f-8feed8e0c300", new Guid("39fd3f9a-1911-4676-b4cf-d245f68a83a7"), "Junior", "Onsite", "Basic knowledge in Swift, iOS", "Support mobile dev team", "7000-9000 zł netto", "Swift", "Junior Mobile Developer", "Mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
