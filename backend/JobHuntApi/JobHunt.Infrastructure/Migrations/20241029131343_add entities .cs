using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addentities : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.id);
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
                    job_level = table.Column<string>(type: "text", nullable: false),
                    responsibilities = table.Column<string>(type: "text", nullable: false),
                    requirements = table.Column<string>(type: "text", nullable: false),
                    company_logo = table.Column<string>(type: "text", nullable: true),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    avatar = table.Column<string>(type: "text", nullable: true),
                    createdBy = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_profiles_addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "addresses",
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
                    work_from = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    location = table.Column<string>(type: "text", nullable: false),
                    work_to = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiences", x => x.id);
                    table.ForeignKey(
                        name: "FK_experiences_profiles_user_id",
                        column: x => x.user_id,
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
                    study_from = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    study_to = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                columns: new[] { "id", "city", "country", "CreatedAt", "street", "UpdatedAt" },
                values: new object[] { new Guid("76e24589-638c-4cb9-9970-675a263a7a43"), "New York", "USA ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "street address 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "id", "AddressId", "avatar", "CreatedAt", "createdBy", "DateOfBirth", "email", "lastname", "name", "phone", "UpdatedAt" },
                values: new object[] { new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), new Guid("76e24589-638c-4cb9-9970-675a263a7a43"), "avatar.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(3651), "john@doe.com", "Doe", "John ", "123456789", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("53cab9de-00e3-4573-8cbd-eaaf68402277"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8371) },
                    { new Guid("92a14daf-487b-43e2-87f1-57e375ff3c8b"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8367) },
                    { new Guid("a1d26e31-8ef1-4fc3-a729-cafe20379389"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8373), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8374) }
                });

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("21392d53-ebce-4353-9953-4c289fede0af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5878), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc609e0c-8205-4c19-8dac-f08afbafe14a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5864), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e55cbf54-34b0-487b-9d1d-14e461811ddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5876), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_experiences_user_id",
                table: "experiences",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_address_id",
                table: "jobs",
                column: "address_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_jobs_title_job_level_technology_type",
                table: "jobs",
                columns: new[] { "title", "job_level", "technology", "type" })
                .Annotation("Npgsql:IndexMethod", "GIN")
                .Annotation("Npgsql:TsVectorConfig", "english");

            migrationBuilder.CreateIndex(
                name: "IX_profiles_AddressId",
                table: "profiles",
                column: "AddressId",
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
                name: "jobs");

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
                name: "profiles");

            migrationBuilder.DropTable(
                name: "addresses");
        }
    }
}
