using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingkeytouserstable5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("27d0d36a-5dd8-46b0-a9ce-8bab3bf7df74"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3159f6f0-224d-4f8c-983c-8e748e628448"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("737699a6-e9ae-4413-a920-8fecc0c64ae2"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("3f5bb1d5-f920-495d-9393-5da3d80fce39"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("771853d5-050a-450f-ae63-13b5be95d4aa"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("ea733b5f-b93a-48f6-b4a2-5235ae28ffdd"));

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("0e53b857-23cb-4734-848f-4486aa2aba6d"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 22, 20, 15, 10, 942, DateTimeKind.Utc).AddTicks(9673), new DateTime(2024, 10, 22, 20, 15, 10, 942, DateTimeKind.Utc).AddTicks(9676) },
                    { new Guid("3eacccc2-c5de-4636-ba54-46f8a24d49f0"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 22, 20, 15, 10, 942, DateTimeKind.Utc).AddTicks(9683), new DateTime(2024, 10, 22, 20, 15, 10, 942, DateTimeKind.Utc).AddTicks(9684) },
                    { new Guid("a330a3cc-02fe-4e2c-8ec8-592bf3969783"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 22, 20, 15, 10, 942, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 10, 22, 20, 15, 10, 942, DateTimeKind.Utc).AddTicks(9680) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("0e6c03d1-6f19-403e-b98a-fab05ff271a5"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(8122), new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(8123), "Vistula 3" },
                    { new Guid("427c4440-679a-4d57-bf05-3b97975e1f8a"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(8096), new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(8098), "Vistula" },
                    { new Guid("45bfc99b-2674-49d6-98c7-4f79c9d271bb"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(8104), new DateTime(2024, 10, 22, 20, 15, 10, 943, DateTimeKind.Utc).AddTicks(8104), "Vistula 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("0e53b857-23cb-4734-848f-4486aa2aba6d"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3eacccc2-c5de-4636-ba54-46f8a24d49f0"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("a330a3cc-02fe-4e2c-8ec8-592bf3969783"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("0e6c03d1-6f19-403e-b98a-fab05ff271a5"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("427c4440-679a-4d57-bf05-3b97975e1f8a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("45bfc99b-2674-49d6-98c7-4f79c9d271bb"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("27d0d36a-5dd8-46b0-a9ce-8bab3bf7df74"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 22, 20, 13, 40, 281, DateTimeKind.Utc).AddTicks(8460), new DateTime(2024, 10, 22, 20, 13, 40, 281, DateTimeKind.Utc).AddTicks(8461) },
                    { new Guid("3159f6f0-224d-4f8c-983c-8e748e628448"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 22, 20, 13, 40, 281, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 10, 22, 20, 13, 40, 281, DateTimeKind.Utc).AddTicks(8441) },
                    { new Guid("737699a6-e9ae-4413-a920-8fecc0c64ae2"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 22, 20, 13, 40, 281, DateTimeKind.Utc).AddTicks(8445), new DateTime(2024, 10, 22, 20, 13, 40, 281, DateTimeKind.Utc).AddTicks(8446) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("3f5bb1d5-f920-495d-9393-5da3d80fce39"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(7388), "Vistula 3" },
                    { new Guid("771853d5-050a-450f-ae63-13b5be95d4aa"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(7385), new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(7385), "Vistula 2" },
                    { new Guid("ea733b5f-b93a-48f6-b4a2-5235ae28ffdd"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(7379), new DateTime(2024, 10, 22, 20, 13, 40, 282, DateTimeKind.Utc).AddTicks(7380), "Vistula" }
                });
        }
    }
}
