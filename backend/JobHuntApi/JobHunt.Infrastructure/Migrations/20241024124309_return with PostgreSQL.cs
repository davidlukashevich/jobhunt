using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class returnwithPostgreSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("0ae6e14f-29c0-4e6a-9931-b538ef8469c1"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("622a45eb-6941-4ceb-b0a7-61351496af6e"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("f013a84f-57bf-4dab-ae13-499ff7823522"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("7150b36e-7b26-47f1-b52e-aeaa30b4a7a3"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("817bf067-c928-4b1c-8757-42bad4f38393"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("fcc91f4c-92e8-4c00-975e-cf0087dffa24"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "profiles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "addresses",
                newName: "id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "id",
                table: "profiles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "addresses",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("0ae6e14f-29c0-4e6a-9931-b538ef8469c1"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 11, 16, 33, 318, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 10, 24, 11, 16, 33, 318, DateTimeKind.Utc).AddTicks(8439) },
                    { new Guid("622a45eb-6941-4ceb-b0a7-61351496af6e"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 11, 16, 33, 318, DateTimeKind.Utc).AddTicks(8429), new DateTime(2024, 10, 24, 11, 16, 33, 318, DateTimeKind.Utc).AddTicks(8431) },
                    { new Guid("f013a84f-57bf-4dab-ae13-499ff7823522"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 11, 16, 33, 318, DateTimeKind.Utc).AddTicks(8443), new DateTime(2024, 10, 24, 11, 16, 33, 318, DateTimeKind.Utc).AddTicks(8443) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 24, 11, 16, 33, 319, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7150b36e-7b26-47f1-b52e-aeaa30b4a7a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 24, 11, 16, 33, 320, DateTimeKind.Utc).AddTicks(2855), new DateTime(2024, 10, 24, 11, 16, 33, 320, DateTimeKind.Utc).AddTicks(2858), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("817bf067-c928-4b1c-8757-42bad4f38393"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 24, 11, 16, 33, 320, DateTimeKind.Utc).AddTicks(2886), new DateTime(2024, 10, 24, 11, 16, 33, 320, DateTimeKind.Utc).AddTicks(2887), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fcc91f4c-92e8-4c00-975e-cf0087dffa24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 24, 11, 16, 33, 320, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 10, 24, 11, 16, 33, 320, DateTimeKind.Utc).AddTicks(2880), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
