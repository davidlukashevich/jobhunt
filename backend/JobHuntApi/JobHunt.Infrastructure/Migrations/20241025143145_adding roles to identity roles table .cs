using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingrolestoidentityrolestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("59d8b973-8a93-4f6b-a2cb-87f55f58f5d9"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("8121e466-1a8d-4453-912b-94fcd26efd38"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("8b7767de-f6e1-4045-af50-47342b75d983"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("56fb3bb9-c417-477e-85b9-d9f286e94955"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("cba87619-dbbe-40ab-ad75-bab63ee1244a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("d3a0724b-b0ab-43a2-8786-e4119f5502dc"));

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("34f6dbcb-9e39-4576-8648-174a16c7dac1"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 14, 31, 44, 642, DateTimeKind.Utc).AddTicks(4336), new DateTime(2024, 10, 25, 14, 31, 44, 642, DateTimeKind.Utc).AddTicks(4337) },
                    { new Guid("5a7e703d-f205-4d5a-8a04-83945d6ba099"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 14, 31, 44, 642, DateTimeKind.Utc).AddTicks(4329), new DateTime(2024, 10, 25, 14, 31, 44, 642, DateTimeKind.Utc).AddTicks(4330) },
                    { new Guid("b86980a5-95bf-403e-ab5b-0c920369185b"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 14, 31, 44, 642, DateTimeKind.Utc).AddTicks(4313), new DateTime(2024, 10, 25, 14, 31, 44, 642, DateTimeKind.Utc).AddTicks(4317) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 25, 14, 31, 44, 646, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6fd78096-7572-4fa1-880d-da3fba765ca8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 25, 14, 31, 44, 647, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 10, 25, 14, 31, 44, 647, DateTimeKind.Utc).AddTicks(2292), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7cafcd8b-b659-43d3-8d66-8ae1e0390a43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 25, 14, 31, 44, 647, DateTimeKind.Utc).AddTicks(2303), new DateTime(2024, 10, 25, 14, 31, 44, 647, DateTimeKind.Utc).AddTicks(2304), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3ae5264-15c1-4033-8c47-787d5554ead4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 25, 14, 31, 44, 647, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 10, 25, 14, 31, 44, 647, DateTimeKind.Utc).AddTicks(2311), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("34f6dbcb-9e39-4576-8648-174a16c7dac1"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("5a7e703d-f205-4d5a-8a04-83945d6ba099"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("b86980a5-95bf-403e-ab5b-0c920369185b"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("6fd78096-7572-4fa1-880d-da3fba765ca8"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("7cafcd8b-b659-43d3-8d66-8ae1e0390a43"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("b3ae5264-15c1-4033-8c47-787d5554ead4"));

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("59d8b973-8a93-4f6b-a2cb-87f55f58f5d9"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 14, 28, 41, 709, DateTimeKind.Utc).AddTicks(3400), new DateTime(2024, 10, 25, 14, 28, 41, 709, DateTimeKind.Utc).AddTicks(3402) },
                    { new Guid("8121e466-1a8d-4453-912b-94fcd26efd38"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 14, 28, 41, 709, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 10, 25, 14, 28, 41, 709, DateTimeKind.Utc).AddTicks(3412) },
                    { new Guid("8b7767de-f6e1-4045-af50-47342b75d983"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 14, 28, 41, 709, DateTimeKind.Utc).AddTicks(3418), new DateTime(2024, 10, 25, 14, 28, 41, 709, DateTimeKind.Utc).AddTicks(3418) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 25, 14, 28, 41, 710, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("56fb3bb9-c417-477e-85b9-d9f286e94955"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 25, 14, 28, 41, 710, DateTimeKind.Utc).AddTicks(9986), new DateTime(2024, 10, 25, 14, 28, 41, 710, DateTimeKind.Utc).AddTicks(9988), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cba87619-dbbe-40ab-ad75-bab63ee1244a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 25, 14, 28, 41, 711, DateTimeKind.Utc), new DateTime(2024, 10, 25, 14, 28, 41, 711, DateTimeKind.Utc), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3a0724b-b0ab-43a2-8786-e4119f5502dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 25, 14, 28, 41, 710, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 10, 25, 14, 28, 41, 710, DateTimeKind.Utc).AddTicks(9995), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
