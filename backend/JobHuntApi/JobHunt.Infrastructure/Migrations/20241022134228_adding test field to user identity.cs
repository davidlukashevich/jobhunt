using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingtestfieldtouseridentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUser",
                table: "IdentityUser");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("3734be0d-e047-46db-93a3-3a4f312277a2"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("72ac3901-4b6d-43d7-af31-8b4216d4d6ad"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("d4031e87-5fb1-4e0a-9c5d-5863b5eb8259"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("83e8dba7-1592-4d73-827c-5b0179ddd3d6"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("9f7320a0-91cf-4b8b-8d8c-1fb49def3a3a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("f6963469-f574-40bf-9058-40f92bc91d2c"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IdentityUser");

            migrationBuilder.RenameTable(
                name: "IdentityUser",
                newName: "Users");

            migrationBuilder.AddColumn<string>(
                name: "TestField",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "TestField",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "IdentityUser");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IdentityUser",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUser",
                table: "IdentityUser",
                column: "Id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("3734be0d-e047-46db-93a3-3a4f312277a2"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 22, 9, 7, 56, 262, DateTimeKind.Utc).AddTicks(2953), new DateTime(2024, 10, 22, 9, 7, 56, 262, DateTimeKind.Utc).AddTicks(2954) },
                    { new Guid("72ac3901-4b6d-43d7-af31-8b4216d4d6ad"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 22, 9, 7, 56, 262, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 10, 22, 9, 7, 56, 262, DateTimeKind.Utc).AddTicks(2934) },
                    { new Guid("d4031e87-5fb1-4e0a-9c5d-5863b5eb8259"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 22, 9, 7, 56, 262, DateTimeKind.Utc).AddTicks(2924), new DateTime(2024, 10, 22, 9, 7, 56, 262, DateTimeKind.Utc).AddTicks(2926) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("83e8dba7-1592-4d73-827c-5b0179ddd3d6"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(4996), new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(4996), "Vistula 2" },
                    { new Guid("9f7320a0-91cf-4b8b-8d8c-1fb49def3a3a"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(5001), new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(5002), "Vistula 3" },
                    { new Guid("f6963469-f574-40bf-9058-40f92bc91d2c"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(4988), new DateTime(2024, 10, 22, 9, 7, 56, 263, DateTimeKind.Utc).AddTicks(4990), "Vistula" }
                });
        }
    }
}
