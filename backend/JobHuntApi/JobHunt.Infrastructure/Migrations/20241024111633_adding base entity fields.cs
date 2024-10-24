using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingbaseentityfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "universities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "universities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "profiles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "profiles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "jobs",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "jobs",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "experiences",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "experiences",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "addresses",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "addresses",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: new Guid("76e24589-638c-4cb9-9970-675a263a7a43"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "CreatedAt", "DateOfBirth", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 11, 16, 33, 319, DateTimeKind.Utc).AddTicks(8927), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "universities");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "universities");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "experiences");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "experiences");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "addresses");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "addresses");

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
    }
}
