using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingkeytouserstable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("26ae5e69-5534-460d-8bc0-1c6cd358095e"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("30b27bf4-a5d3-4d7c-8798-895a6f01038c"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("fe0fb5ab-e04c-43aa-90bd-d7cc7417c2a8"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("4d36cf86-e9fb-4f02-9704-a33f174af52b"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("95f0c796-0eb6-4525-aaae-ab9712fd3901"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("df716e47-8642-49a4-b567-63cb301dc92e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("26ae5e69-5534-460d-8bc0-1c6cd358095e"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 22, 20, 9, 7, 198, DateTimeKind.Utc).AddTicks(325), new DateTime(2024, 10, 22, 20, 9, 7, 198, DateTimeKind.Utc).AddTicks(326) },
                    { new Guid("30b27bf4-a5d3-4d7c-8798-895a6f01038c"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 22, 20, 9, 7, 198, DateTimeKind.Utc).AddTicks(316), new DateTime(2024, 10, 22, 20, 9, 7, 198, DateTimeKind.Utc).AddTicks(318) },
                    { new Guid("fe0fb5ab-e04c-43aa-90bd-d7cc7417c2a8"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 22, 20, 9, 7, 198, DateTimeKind.Utc).AddTicks(329), new DateTime(2024, 10, 22, 20, 9, 7, 198, DateTimeKind.Utc).AddTicks(330) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("4d36cf86-e9fb-4f02-9704-a33f174af52b"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(3447), new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(3448), "Vistula" },
                    { new Guid("95f0c796-0eb6-4525-aaae-ab9712fd3901"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(3458), new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(3459), "Vistula 3" },
                    { new Guid("df716e47-8642-49a4-b567-63cb301dc92e"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(3454), new DateTime(2024, 10, 22, 20, 9, 7, 199, DateTimeKind.Utc).AddTicks(3455), "Vistula 2" }
                });
        }
    }
}
