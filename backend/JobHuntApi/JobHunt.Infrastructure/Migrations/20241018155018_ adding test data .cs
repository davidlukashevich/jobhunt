using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingtestdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_universities_profiles_user_id",
                table: "universities");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "universities",
                newName: "profile_id");

            migrationBuilder.RenameIndex(
                name: "IX_universities_user_id",
                table: "universities",
                newName: "IX_universities_profile_id");

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "Id", "city", "country", "street" },
                values: new object[] { new Guid("76e24589-638c-4cb9-9970-675a263a7a43"), "New York", "USA ", "street address 1" });

            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "Id", "AddressId", "avatar", "DateOfBirth", "email", "lastname", "name", "phone" },
                values: new object[] { new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), new Guid("76e24589-638c-4cb9-9970-675a263a7a43"), "avatar.jpg", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(5333), "john@doe.com", "Doe", "John ", "123456789" });

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "location", "position", "user_id", "responsibility", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("2d96ea5a-2b05-4d22-9650-f114a0e174cc"), "CompanyName 3", "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4546), new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4546) },
                    { new Guid("322dc990-9143-4abf-8f03-230818289510"), "CompanyName", "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4505) },
                    { new Guid("5be86c52-acd3-4d6a-b7c2-4fef83670298"), "CompanyName 2", "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 10, 18, 15, 50, 17, 733, DateTimeKind.Utc).AddTicks(4516) }
                });

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name" },
                values: new object[,]
                {
                    { new Guid("45353996-bce9-4c76-b234-bc4a696ea26f"), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9077), new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9077), "Vistula 3" },
                    { new Guid("967731ff-3739-4745-a36e-ed73d573f61f"), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9071), new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9072), "Vistula 2" },
                    { new Guid("b6c0debb-850f-43ca-b6fe-d54b5847d258"), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9062), new DateTime(2024, 10, 18, 15, 50, 17, 734, DateTimeKind.Utc).AddTicks(9064), "Vistula" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_universities_profiles_profile_id",
                table: "universities",
                column: "profile_id",
                principalTable: "profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_universities_profiles_profile_id",
                table: "universities");

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

            migrationBuilder.DeleteData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: new Guid("76e24589-638c-4cb9-9970-675a263a7a43"));

            migrationBuilder.RenameColumn(
                name: "profile_id",
                table: "universities",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_universities_profile_id",
                table: "universities",
                newName: "IX_universities_user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_universities_profiles_user_id",
                table: "universities",
                column: "user_id",
                principalTable: "profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
