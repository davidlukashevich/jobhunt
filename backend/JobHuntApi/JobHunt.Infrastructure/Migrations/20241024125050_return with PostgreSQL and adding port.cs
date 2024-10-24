using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class returnwithPostgreSQLandaddingport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("940ce0dc-19e5-440a-a502-6ee3e882c1e6"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("94618ab8-89fc-4b8f-a1eb-7bb18fefa3a0"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("a9f59f8e-48c9-4188-ac88-69e4a53b43ee"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("247be9f5-3b7c-4129-aa96-943e3680eaeb"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("a43b249c-f070-4196-a8d0-d77fb2064b3c"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("ca1a12ea-6ed7-4b7b-978e-ddf9707d01e7"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("940ce0dc-19e5-440a-a502-6ee3e882c1e6"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 12, 43, 8, 947, DateTimeKind.Utc).AddTicks(845), new DateTime(2024, 10, 24, 12, 43, 8, 947, DateTimeKind.Utc).AddTicks(847) },
                    { new Guid("94618ab8-89fc-4b8f-a1eb-7bb18fefa3a0"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 12, 43, 8, 947, DateTimeKind.Utc).AddTicks(861), new DateTime(2024, 10, 24, 12, 43, 8, 947, DateTimeKind.Utc).AddTicks(862) },
                    { new Guid("a9f59f8e-48c9-4188-ac88-69e4a53b43ee"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 12, 43, 8, 947, DateTimeKind.Utc).AddTicks(856), new DateTime(2024, 10, 24, 12, 43, 8, 947, DateTimeKind.Utc).AddTicks(857) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("247be9f5-3b7c-4129-aa96-943e3680eaeb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(4468), new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(4469), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a43b249c-f070-4196-a8d0-d77fb2064b3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(4476), new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(4477), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca1a12ea-6ed7-4b7b-978e-ddf9707d01e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(4482), new DateTime(2024, 10, 24, 12, 43, 8, 948, DateTimeKind.Utc).AddTicks(4482), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
