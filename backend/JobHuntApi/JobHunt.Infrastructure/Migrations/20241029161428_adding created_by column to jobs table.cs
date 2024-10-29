using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingcreated_bycolumntojobstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("53cab9de-00e3-4573-8cbd-eaaf68402277"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("92a14daf-487b-43e2-87f1-57e375ff3c8b"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("a1d26e31-8ef1-4fc3-a729-cafe20379389"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("21392d53-ebce-4353-9953-4c289fede0af"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("dc609e0c-8205-4c19-8dac-f08afbafe14a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("e55cbf54-34b0-487b-9d1d-14e461811ddd"));

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "jobs",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("20f80c46-f0c0-4dbc-b00e-7fe76197f932"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7390), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a86e9a33-683e-45be-9dea-4aa4d420b9db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7364), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4bc5581-723a-46a7-b1f5-bd3830521232"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7384), new DateTime(2024, 10, 29, 16, 14, 27, 835, DateTimeKind.Utc).AddTicks(7385), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "created_by",
                table: "jobs");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("53cab9de-00e3-4573-8cbd-eaaf68402277"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8371) },
                    { new Guid("92a14daf-487b-43e2-87f1-57e375ff3c8b"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8367) },
                    { new Guid("a1d26e31-8ef1-4fc3-a729-cafe20379389"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8373), new DateTime(2024, 10, 29, 13, 13, 43, 66, DateTimeKind.Utc).AddTicks(8374) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("21392d53-ebce-4353-9953-4c289fede0af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5878), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc609e0c-8205-4c19-8dac-f08afbafe14a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5864), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e55cbf54-34b0-487b-9d1d-14e461811ddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 10, 29, 13, 13, 43, 67, DateTimeKind.Utc).AddTicks(5876), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
