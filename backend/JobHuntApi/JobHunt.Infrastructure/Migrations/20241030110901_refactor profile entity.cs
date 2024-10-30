using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class refactorprofileentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("32304f51-ce60-40d9-9231-31ce88262bce"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("b57bd5ce-3717-4dbc-8174-cbbeb4f202cc"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("d936f619-4c27-4f28-b779-0d97eba172c5"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("2fe4d5ce-6bcd-4443-9577-fe041b3a1b2a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("6e6cdb3e-b4d5-41ad-94ed-03e280d520dd"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("e2483782-a4a6-44be-b94b-e269027891e0"));

            migrationBuilder.AddColumn<string>(
                name: "profile_image",
                table: "profiles",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("1e72ff2c-79c2-4392-b359-c362265fc658"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 9, 0, 554, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 10, 30, 11, 9, 0, 554, DateTimeKind.Utc).AddTicks(6882) },
                    { new Guid("9238660e-0b43-488a-8ecc-b3aa675e595d"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 9, 0, 554, DateTimeKind.Utc).AddTicks(6877), new DateTime(2024, 10, 30, 11, 9, 0, 554, DateTimeKind.Utc).AddTicks(6877) },
                    { new Guid("bdb3684f-9598-4a68-a4c7-5c306acf4d9a"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 9, 0, 554, DateTimeKind.Utc).AddTicks(6866), new DateTime(2024, 10, 30, 11, 9, 0, 554, DateTimeKind.Utc).AddTicks(6869) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                columns: new[] { "DateOfBirth", "profile_image" },
                values: new object[] { new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(5981), null });

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("25dd644c-5b09-469a-93c3-ebfb9a1b828f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9897), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b1ac4a6-f30f-4e93-ad6f-d174fa49bfa2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9902), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b03043d4-c99f-49cb-aca6-b0e00328465f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9877), new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9878), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("1e72ff2c-79c2-4392-b359-c362265fc658"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("9238660e-0b43-488a-8ecc-b3aa675e595d"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("bdb3684f-9598-4a68-a4c7-5c306acf4d9a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("25dd644c-5b09-469a-93c3-ebfb9a1b828f"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("3b1ac4a6-f30f-4e93-ad6f-d174fa49bfa2"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("b03043d4-c99f-49cb-aca6-b0e00328465f"));

            migrationBuilder.DropColumn(
                name: "profile_image",
                table: "profiles");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("32304f51-ce60-40d9-9231-31ce88262bce"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5079), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5079) },
                    { new Guid("b57bd5ce-3717-4dbc-8174-cbbeb4f202cc"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5064), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5067) },
                    { new Guid("d936f619-4c27-4f28-b779-0d97eba172c5"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5074), new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5074) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 30, 11, 5, 26, 371, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2fe4d5ce-6bcd-4443-9577-fe041b3a1b2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4387), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e6cdb3e-b4d5-41ad-94ed-03e280d520dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4392), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2483782-a4a6-44be-b94b-e269027891e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4376), new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4378), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
