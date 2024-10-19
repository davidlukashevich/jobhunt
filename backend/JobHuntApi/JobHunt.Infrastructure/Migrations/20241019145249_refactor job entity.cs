using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class refactorjobentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("027c906d-2e47-4f78-97da-35747551d30b"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("257cf1f6-69d3-484b-a3b3-e60383afb8e9"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("d6a1de3a-ae10-4949-9dc8-0b9aad0136f7"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("0d24c05c-e75d-4762-9080-28ee72f4993f"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("5f36f1c6-73c8-4abd-9509-61616916677b"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("972b81f2-b557-46f6-b879-6f4781b06df1"));

            migrationBuilder.AddColumn<string>(
                name: "technology",
                table: "jobs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "jobs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("0bbc714c-6c65-4fe9-944e-656b3693fb1b"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 19, 14, 52, 49, 205, DateTimeKind.Utc).AddTicks(2402), new DateTime(2024, 10, 19, 14, 52, 49, 205, DateTimeKind.Utc).AddTicks(2402) },
                    { new Guid("2a0a7aff-801c-4fd6-b0ba-62ef0f897c99"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 19, 14, 52, 49, 205, DateTimeKind.Utc).AddTicks(2407), new DateTime(2024, 10, 19, 14, 52, 49, 205, DateTimeKind.Utc).AddTicks(2408) },
                    { new Guid("c24d6a35-9bdd-47f6-955f-f0453ede3195"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 19, 14, 52, 49, 205, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 10, 19, 14, 52, 49, 205, DateTimeKind.Utc).AddTicks(2377) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("216da130-c0df-4fb6-9703-b39b4a6cd40d"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(9893), "Vistula 2" },
                    { new Guid("2b4573df-9efd-4796-8f6f-380fdea2a418"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(9897), "Vistula 3" },
                    { new Guid("c0089150-df67-44c8-b806-4fe57840bf9e"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(9883), new DateTime(2024, 10, 19, 14, 52, 49, 206, DateTimeKind.Utc).AddTicks(9884), "Vistula" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("0bbc714c-6c65-4fe9-944e-656b3693fb1b"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("2a0a7aff-801c-4fd6-b0ba-62ef0f897c99"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("c24d6a35-9bdd-47f6-955f-f0453ede3195"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("216da130-c0df-4fb6-9703-b39b4a6cd40d"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("2b4573df-9efd-4796-8f6f-380fdea2a418"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("c0089150-df67-44c8-b806-4fe57840bf9e"));

            migrationBuilder.DropColumn(
                name: "technology",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "type",
                table: "jobs");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("027c906d-2e47-4f78-97da-35747551d30b"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 19, 13, 33, 51, 273, DateTimeKind.Utc).AddTicks(727), new DateTime(2024, 10, 19, 13, 33, 51, 273, DateTimeKind.Utc).AddTicks(728) },
                    { new Guid("257cf1f6-69d3-484b-a3b3-e60383afb8e9"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 19, 13, 33, 51, 273, DateTimeKind.Utc).AddTicks(719), new DateTime(2024, 10, 19, 13, 33, 51, 273, DateTimeKind.Utc).AddTicks(721) },
                    { new Guid("d6a1de3a-ae10-4949-9dc8-0b9aad0136f7"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 19, 13, 33, 51, 273, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 10, 19, 13, 33, 51, 273, DateTimeKind.Utc).AddTicks(747) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("0d24c05c-e75d-4762-9080-28ee72f4993f"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(4939), new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(4941), "Vistula" },
                    { new Guid("5f36f1c6-73c8-4abd-9509-61616916677b"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(4948), new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(4948), "Vistula 2" },
                    { new Guid("972b81f2-b557-46f6-b879-6f4781b06df1"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(4953), new DateTime(2024, 10, 19, 13, 33, 51, 274, DateTimeKind.Utc).AddTicks(4953), "Vistula 3" }
                });
        }
    }
}
