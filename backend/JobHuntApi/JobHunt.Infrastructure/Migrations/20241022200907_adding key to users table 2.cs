using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingkeytouserstable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("22f4732c-151f-44ee-9600-260f3860ba12"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3666bd08-506a-4467-858c-e89b1c633f28"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("999a46bb-10e9-45b3-8179-900c0eb4d363"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("1b9c5c20-f490-4aeb-ad73-6dedf2018159"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("2f663f25-ba71-45ed-83bf-c460d38032d0"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("d142426c-5016-4798-9768-ec9ff3165a69"));

            migrationBuilder.RenameColumn(
                name: "TestField",
                table: "Users",
                newName: "FullName");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "TestField");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("22f4732c-151f-44ee-9600-260f3860ba12"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(1415) },
                    { new Guid("3666bd08-506a-4467-858c-e89b1c633f28"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(1412), new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(1412) },
                    { new Guid("999a46bb-10e9-45b3-8179-900c0eb4d363"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(1407), new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(1409) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("1b9c5c20-f490-4aeb-ad73-6dedf2018159"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(7435), new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(7435), "Vistula 3" },
                    { new Guid("2f663f25-ba71-45ed-83bf-c460d38032d0"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(7433), "Vistula 2" },
                    { new Guid("d142426c-5016-4798-9768-ec9ff3165a69"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 10, 22, 13, 42, 28, 264, DateTimeKind.Utc).AddTicks(7429), "Vistula" }
                });
        }
    }
}
