using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingcascadedeletebetweenjobandaddressentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("2d96ea5a-2b05-4d22-9650-f114a0e174cc"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("322dc990-9143-4abf-8f03-230818289510"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("5be86c52-acd3-4d6a-b7c2-4fef83670298"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("45353996-bce9-4c76-b234-bc4a696ea26f"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("967731ff-3739-4745-a36e-ed73d573f61f"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("b6c0debb-850f-43ca-b6fe-d54b5847d258"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("2d96ea5a-2b05-4d22-9650-f114a0e174cc"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4546), new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4546) },
                    { new Guid("322dc990-9143-4abf-8f03-230818289510"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4505) },
                    { new Guid("5be86c52-acd3-4d6a-b7c2-4fef83670298"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4516) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("45353996-bce9-4c76-b234-bc4a696ea26f"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9077), new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9077), "Vistula 3" },
                    { new Guid("967731ff-3739-4745-a36e-ed73d573f61f"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9071), new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9072), "Vistula 2" },
                    { new Guid("b6c0debb-850f-43ca-b6fe-d54b5847d258"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9062), new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9064), "Vistula" }
                });
        }
    }
}
