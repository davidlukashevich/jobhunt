using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    street = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    image_url = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: true),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    technology = table.Column<string>(type: "text", nullable: false),
                    company_name = table.Column<string>(type: "text", nullable: false),
                    operation_mode = table.Column<string>(type: "text", nullable: false),
                    contract_type = table.Column<string>(type: "text", nullable: false),
                    about_company = table.Column<string>(type: "text", nullable: false),
                    job_level = table.Column<string>(type: "text", nullable: false),
                    responsibilities = table.Column<string>(type: "text", nullable: false),
                    requirements = table.Column<string>(type: "text", nullable: false),
                    created_by = table.Column<string>(type: "text", nullable: false),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    image_id = table.Column<Guid>(type: "uuid", nullable: false),
                    salary = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.id);
                    table.ForeignKey(
                        name: "FK_jobs_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_jobs_images_image_id",
                        column: x => x.image_id,
                        principalTable: "images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    created_by = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    image_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_profiles_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_profiles_images_image_id",
                        column: x => x.image_id,
                        principalTable: "images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job_applications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: true),
                    about_information = table.Column<string>(type: "text", nullable: true),
                    cv = table.Column<string>(type: "text", nullable: false),
                    job_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_by = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_applications", x => x.id);
                    table.ForeignKey(
                        name: "FK_job_applications_jobs_job_id",
                        column: x => x.job_id,
                        principalTable: "jobs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experiences",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    position = table.Column<string>(type: "text", nullable: false),
                    company_name = table.Column<string>(type: "text", nullable: false),
                    responsibility = table.Column<string>(type: "text", nullable: false),
                    work_from = table.Column<DateOnly>(type: "date", nullable: false),
                    location = table.Column<string>(type: "text", nullable: false),
                    work_to = table.Column<DateOnly>(type: "date", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiences", x => x.id);
                    table.ForeignKey(
                        name: "FK_experiences_profiles_profile_id",
                        column: x => x.profile_id,
                        principalTable: "profiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "universities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    university_name = table.Column<string>(type: "text", nullable: false),
                    education_level = table.Column<string>(type: "text", nullable: false),
                    field_of_study = table.Column<string>(type: "text", nullable: false),
                    specialization = table.Column<string>(type: "text", nullable: false),
                    study_from = table.Column<DateOnly>(type: "date", nullable: false),
                    study_to = table.Column<DateOnly>(type: "date", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universities", x => x.id);
                    table.ForeignKey(
                        name: "FK_universities_profiles_profile_id",
                        column: x => x.profile_id,
                        principalTable: "profiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Employer", "EMPLOYER" },
                    { "2", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "id", "city", "country", "created_at", "street", "updated_at" },
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
                columns: new[] { "id", "created_at", "image_url", "name", "updated_at" },
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

            migrationBuilder.CreateIndex(
                name: "IX_experiences_profile_id",
                table: "experiences",
                column: "profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_applications_job_id",
                table: "job_applications",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_address_id",
                table: "jobs",
                column: "address_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_jobs_image_id",
                table: "jobs",
                column: "image_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_jobs_title_job_level_technology_type",
                table: "jobs",
                columns: new[] { "title", "job_level", "technology", "type" })
                .Annotation("Npgsql:IndexMethod", "GIN")
                .Annotation("Npgsql:TsVectorConfig", "english");

            migrationBuilder.CreateIndex(
                name: "IX_profiles_address_id",
                table: "profiles",
                column: "address_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_profiles_image_id",
                table: "profiles",
                column: "image_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_universities_profile_id",
                table: "universities",
                column: "profile_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "experiences");

            migrationBuilder.DropTable(
                name: "job_applications");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "universities");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "images");
        }
    }
}
