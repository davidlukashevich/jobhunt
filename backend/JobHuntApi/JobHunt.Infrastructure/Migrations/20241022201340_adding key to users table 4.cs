using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingkeytouserstable4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "id",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("1ab43e84-ca94-40b9-80f6-ac2f59a2055e"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("c73a7d32-6978-4e67-b6bb-9308864e80cc"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("d9d9e7fb-0964-4f2f-bf58-e9c769707d97"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("42a23632-2eba-47b0-911d-8120f085cd28"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("62e96c44-75cc-445b-9fcd-3780be7c0ab0"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("763ded4f-f666-415a-853a-1db9840b8ae3"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

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

            migrationBuilder.AddPrimaryKey(
                name: "id",
                table: "Users",
                column: "Id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("1ab43e84-ca94-40b9-80f6-ac2f59a2055e"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 22, 20, 12, 43, 349, DateTimeKind.Utc).AddTicks(5342), new DateTime(2024, 10, 22, 20, 12, 43, 349, DateTimeKind.Utc).AddTicks(5342) },
                    { new Guid("c73a7d32-6978-4e67-b6bb-9308864e80cc"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 22, 20, 12, 43, 349, DateTimeKind.Utc).AddTicks(5334), new DateTime(2024, 10, 22, 20, 12, 43, 349, DateTimeKind.Utc).AddTicks(5336) },
                    { new Guid("d9d9e7fb-0964-4f2f-bf58-e9c769707d97"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 22, 20, 12, 43, 349, DateTimeKind.Utc).AddTicks(5345), new DateTime(2024, 10, 22, 20, 12, 43, 349, DateTimeKind.Utc).AddTicks(5345) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 22, 20, 12, 43, 350, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("42a23632-2eba-47b0-911d-8120f085cd28"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 22, 20, 12, 43, 351, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 10, 22, 20, 12, 43, 351, DateTimeKind.Utc).AddTicks(552), "Vistula 3" },
                    { new Guid("62e96c44-75cc-445b-9fcd-3780be7c0ab0"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 22, 20, 12, 43, 351, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 10, 22, 20, 12, 43, 351, DateTimeKind.Utc).AddTicks(548), "Vistula 2" },
                    { new Guid("763ded4f-f666-415a-853a-1db9840b8ae3"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 22, 20, 12, 43, 351, DateTimeKind.Utc).AddTicks(539), new DateTime(2024, 10, 22, 20, 12, 43, 351, DateTimeKind.Utc).AddTicks(540), "Vistula" }
                });
        }
    }
}
