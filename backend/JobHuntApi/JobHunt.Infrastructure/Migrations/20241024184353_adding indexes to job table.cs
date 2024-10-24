using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingindexestojobtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("0a34eeb9-1fb0-4877-954d-2e6f05440e01"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("18b10e92-5718-4887-b86b-7cb4ccc4c92d"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3789576c-a879-4dae-8d9f-2d4dafd1c580"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("5f97c1c7-16d6-4e94-86ed-e2a174259f09"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("7bacc2bd-0322-4045-8638-d5fdab3c4ec2"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("af52535f-ba83-49c6-aa56-6660bcba25ee"));

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("299d95da-6c9d-442f-931d-83b7162febed"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 18, 43, 53, 142, DateTimeKind.Utc).AddTicks(8208), new DateTime(2024, 10, 24, 18, 43, 53, 142, DateTimeKind.Utc).AddTicks(8212) },
                    { new Guid("33935239-28f7-4319-b2af-ea9242184e63"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 18, 43, 53, 142, DateTimeKind.Utc).AddTicks(8223), new DateTime(2024, 10, 24, 18, 43, 53, 142, DateTimeKind.Utc).AddTicks(8224) },
                    { new Guid("86d40714-1593-4888-9c69-0f247643982a"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 18, 43, 53, 142, DateTimeKind.Utc).AddTicks(8218), new DateTime(2024, 10, 24, 18, 43, 53, 142, DateTimeKind.Utc).AddTicks(8219) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 24, 18, 43, 53, 143, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7bb983a6-e6ed-4967-84e3-063cc7f8d0bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 24, 18, 43, 53, 144, DateTimeKind.Utc).AddTicks(6760), new DateTime(2024, 10, 24, 18, 43, 53, 144, DateTimeKind.Utc).AddTicks(6761), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("960340c9-77c1-4ed8-8689-0f84264b8b9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 24, 18, 43, 53, 144, DateTimeKind.Utc).AddTicks(6750), new DateTime(2024, 10, 24, 18, 43, 53, 144, DateTimeKind.Utc).AddTicks(6752), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fdb8a4ed-728c-47d9-9369-d0e657d67ff4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 24, 18, 43, 53, 144, DateTimeKind.Utc).AddTicks(6766), new DateTime(2024, 10, 24, 18, 43, 53, 144, DateTimeKind.Utc).AddTicks(6766), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_jobs_title_job_level_technology_type",
                table: "jobs",
                columns: new[] { "title", "job_level", "technology", "type" })
                .Annotation("Npgsql:IndexMethod", "GIN")
                .Annotation("Npgsql:TsVectorConfig", "english");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_jobs_title_job_level_technology_type",
                table: "jobs");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("299d95da-6c9d-442f-931d-83b7162febed"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("33935239-28f7-4319-b2af-ea9242184e63"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("86d40714-1593-4888-9c69-0f247643982a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("7bb983a6-e6ed-4967-84e3-063cc7f8d0bc"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("960340c9-77c1-4ed8-8689-0f84264b8b9b"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("fdb8a4ed-728c-47d9-9369-d0e657d67ff4"));

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("0a34eeb9-1fb0-4877-954d-2e6f05440e01"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 13, 7, 0, 905, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 10, 24, 13, 7, 0, 905, DateTimeKind.Utc).AddTicks(8829) },
                    { new Guid("18b10e92-5718-4887-b86b-7cb4ccc4c92d"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 13, 7, 0, 905, DateTimeKind.Utc).AddTicks(8814), new DateTime(2024, 10, 24, 13, 7, 0, 905, DateTimeKind.Utc).AddTicks(8816) },
                    { new Guid("3789576c-a879-4dae-8d9f-2d4dafd1c580"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 13, 7, 0, 905, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 10, 24, 13, 7, 0, 905, DateTimeKind.Utc).AddTicks(8824) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5f97c1c7-16d6-4e94-86ed-e2a174259f09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(7313), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bacc2bd-0322-4045-8638-d5fdab3c4ec2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(7284), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af52535f-ba83-49c6-aa56-6660bcba25ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 10, 24, 13, 7, 0, 907, DateTimeKind.Utc).AddTicks(7292), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
