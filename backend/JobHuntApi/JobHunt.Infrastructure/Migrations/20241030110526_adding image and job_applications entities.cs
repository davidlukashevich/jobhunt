using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingimageandjob_applicationsentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profiles_addresses_AddressId",
                table: "profiles");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3fb30419-f4a0-46d2-b020-f30896c0013e"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("5be838cf-0c34-4d44-b9a7-d9363ac27233"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("d2c59552-8f32-4ae8-b785-00cb9f3d4bca"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("20f80c46-f0c0-4dbc-b00e-7fe76197f932"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("a86e9a33-683e-45be-9dea-4aa4d420b9db"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("c4bc5581-723a-46a7-b1f5-bd3830521232"));

            migrationBuilder.DropColumn(
                name: "avatar",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "company_logo",
                table: "jobs");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "profiles",
                newName: "address_id");

            migrationBuilder.RenameIndex(
                name: "IX_profiles_AddressId",
                table: "profiles",
                newName: "IX_profiles_address_id");

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    image_url = table.Column<string>(type: "text", nullable: false),
                    JobId = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.id);
                    table.ForeignKey(
                        name: "FK_images_jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "jobs",
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
                    cv = table.Column<string>(type: "text", nullable: true),
                    job_id = table.Column<Guid>(type: "uuid", nullable: false)
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

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("32304f51-ce60-40d9-9231-31ce88262bce"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5079), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5079) },
                    { new Guid("b57bd5ce-3717-4dbc-8174-cbbeb4f202cc"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5064), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5067) },
                    { new Guid("d936f619-4c27-4f28-b779-0d97eba172c5"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5074), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5074) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 30, 11, 5, 26, 371, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2fe4d5ce-6bcd-4443-9577-fe041b3a1b2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4387), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e6cdb3e-b4d5-41ad-94ed-03e280d520dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4392), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2483782-a4a6-44be-b94b-e269027891e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4376), new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4378), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_images_JobId",
                table: "images",
                column: "JobId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_job_applications_job_id",
                table: "job_applications",
                column: "job_id");

            migrationBuilder.AddForeignKey(
                name: "FK_profiles_addresses_address_id",
                table: "profiles",
                column: "address_id",
                principalTable: "addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profiles_addresses_address_id",
                table: "profiles");

            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "job_applications");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("32304f51-ce60-40d9-9231-31ce88262bce"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("b57bd5ce-3717-4dbc-8174-cbbeb4f202cc"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("d936f619-4c27-4f28-b779-0d97eba172c5"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("2fe4d5ce-6bcd-4443-9577-fe041b3a1b2a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("6e6cdb3e-b4d5-41ad-94ed-03e280d520dd"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("e2483782-a4a6-44be-b94b-e269027891e0"));

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "profiles",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_profiles_address_id",
                table: "profiles",
                newName: "IX_profiles_AddressId");

            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "profiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company_logo",
                table: "jobs",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("3fb30419-f4a0-46d2-b020-f30896c0013e"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 14, 27, 833, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 10, 29, 16, 14, 27, 833, DateTimeKind.Utc).AddTicks(9382) },
                    { new Guid("5be838cf-0c34-4d44-b9a7-d9363ac27233"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 14, 27, 833, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 10, 29, 16, 14, 27, 833, DateTimeKind.Utc).AddTicks(9396) },
                    { new Guid("d2c59552-8f32-4ae8-b785-00cb9f3d4bca"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 14, 27, 833, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 10, 29, 16, 14, 27, 833, DateTimeKind.Utc).AddTicks(9391) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                columns: new[] { "avatar", "DateOfBirth" },
                values: new object[] { "avatar.jpg", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("20f80c46-f0c0-4dbc-b00e-7fe76197f932"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7390), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a86e9a33-683e-45be-9dea-4aa4d420b9db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7364), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4bc5581-723a-46a7-b1f5-bd3830521232"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7384), new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7385), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_profiles_addresses_AddressId",
                table: "profiles",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
