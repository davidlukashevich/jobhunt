using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingentities : Migration
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

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("10c15388-7af2-4d7f-b526-7dd12d1147b8"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 20, 53, 522, DateTimeKind.Utc).AddTicks(6889), new DateTime(2024, 10, 29, 13, 20, 53, 522, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("180e5126-87ba-4cc9-9824-8bf71c599cb0"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 20, 53, 522, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 10, 29, 13, 20, 53, 522, DateTimeKind.Utc).AddTicks(6887) },
                    { new Guid("bf79a48b-5c27-4efc-872e-5026aed35f45"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 20, 53, 522, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 10, 29, 13, 20, 53, 522, DateTimeKind.Utc).AddTicks(6875) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0ddf55f8-0d7a-4584-958c-62aa0373a0c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(3977), new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(3978), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fa9b3bb-e5b5-4b1c-8a2a-07047277c544"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(3982), new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(3982), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd61f8c7-fd16-4914-8291-28ba5ddfe9b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(3984), new DateTime(2024, 10, 29, 13, 20, 53, 523, DateTimeKind.Utc).AddTicks(3984), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("10c15388-7af2-4d7f-b526-7dd12d1147b8"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("180e5126-87ba-4cc9-9824-8bf71c599cb0"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("bf79a48b-5c27-4efc-872e-5026aed35f45"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("0ddf55f8-0d7a-4584-958c-62aa0373a0c6"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("8fa9b3bb-e5b5-4b1c-8a2a-07047277c544"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("fd61f8c7-fd16-4914-8291-28ba5ddfe9b2"));

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
