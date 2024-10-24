using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changingnameuserstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("1400a649-473c-47d8-9b93-44baf0fbb3ab"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3e8f48eb-0d57-4ce9-be82-e9736994d5e9"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("4e6e0167-3e2b-453e-8a3c-44b9af39e78b"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("6cf197e2-b115-4f24-b754-f182b6cee40c"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("c5e9b6a7-d9c4-4e1e-abfe-2e1d0170e3d1"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("d7a17df7-5e00-4c92-bfa8-ec78c2f335a7"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1400a649-473c-47d8-9b93-44baf0fbb3ab"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 12, 50, 50, 193, DateTimeKind.Utc).AddTicks(8643), new DateTime(2024, 10, 24, 12, 50, 50, 193, DateTimeKind.Utc).AddTicks(8644) },
                    { new Guid("3e8f48eb-0d57-4ce9-be82-e9736994d5e9"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 12, 50, 50, 193, DateTimeKind.Utc).AddTicks(8662), new DateTime(2024, 10, 24, 12, 50, 50, 193, DateTimeKind.Utc).AddTicks(8663) },
                    { new Guid("4e6e0167-3e2b-453e-8a3c-44b9af39e78b"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 12, 50, 50, 193, DateTimeKind.Utc).AddTicks(8634), new DateTime(2024, 10, 24, 12, 50, 50, 193, DateTimeKind.Utc).AddTicks(8636) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 24, 12, 50, 50, 194, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6cf197e2-b115-4f24-b754-f182b6cee40c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 24, 12, 50, 50, 195, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 10, 24, 12, 50, 50, 195, DateTimeKind.Utc).AddTicks(1201), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5e9b6a7-d9c4-4e1e-abfe-2e1d0170e3d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 24, 12, 50, 50, 195, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 10, 24, 12, 50, 50, 195, DateTimeKind.Utc).AddTicks(1194), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7a17df7-5e00-4c92-bfa8-ec78c2f335a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 24, 12, 50, 50, 195, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 10, 24, 12, 50, 50, 195, DateTimeKind.Utc).AddTicks(1206), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
