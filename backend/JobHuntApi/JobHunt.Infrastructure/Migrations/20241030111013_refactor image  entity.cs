using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class refactorimageentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_jobs_JobId",
                table: "images");

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

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "images",
                newName: "job_id");

            migrationBuilder.RenameIndex(
                name: "IX_images_JobId",
                table: "images",
                newName: "IX_images_job_id");

            migrationBuilder.InsertData(
                table: "experiences",
                columns: new[] { "id", "company_name", "CreatedAt", "location", "position", "user_id", "responsibility", "UpdatedAt", "work_from", "work_to" },
                values: new object[,]
                {
                    { new Guid("79ca853e-8afe-4ebd-aed4-a7a75f397038"), "CompanyName 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Position 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 10, 12, 471, DateTimeKind.Utc).AddTicks(2856), new DateTime(2024, 10, 30, 11, 10, 12, 471, DateTimeKind.Utc).AddTicks(2857) },
                    { new Guid("b6693171-2f85-478c-86cd-8e9f5f48c49d"), "CompanyName", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location", "Position", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 10, 12, 471, DateTimeKind.Utc).AddTicks(2841), new DateTime(2024, 10, 30, 11, 10, 12, 471, DateTimeKind.Utc).AddTicks(2843) },
                    { new Guid("cdd1f690-7871-421b-a9e3-e41e726d1a5a"), "CompanyName 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Position 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Responsibility 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 11, 10, 12, 471, DateTimeKind.Utc).AddTicks(2851), new DateTime(2024, 10, 30, 11, 10, 12, 471, DateTimeKind.Utc).AddTicks(2852) }
                });

            migrationBuilder.UpdateData(
                table: "profiles",
                keyColumn: "id",
                keyValue: new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 30, 11, 10, 12, 474, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4c10ac4e-5661-4013-aab3-0447c0052160"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 30, 11, 10, 12, 475, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 10, 30, 11, 10, 12, 475, DateTimeKind.Utc).AddTicks(1963), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cfcc9cf-3721-44f6-ac68-2a57ff3fb4c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 30, 11, 10, 12, 475, DateTimeKind.Utc).AddTicks(1954), new DateTime(2024, 10, 30, 11, 10, 12, 475, DateTimeKind.Utc).AddTicks(1956), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("814a8376-311d-4fdb-90d2-dc411c4b5e7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 30, 11, 10, 12, 475, DateTimeKind.Utc).AddTicks(1983), new DateTime(2024, 10, 30, 11, 10, 12, 475, DateTimeKind.Utc).AddTicks(2034), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_images_jobs_job_id",
                table: "images",
                column: "job_id",
                principalTable: "jobs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_jobs_job_id",
                table: "images");

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("79ca853e-8afe-4ebd-aed4-a7a75f397038"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("b6693171-2f85-478c-86cd-8e9f5f48c49d"));

            migrationBuilder.DeleteData(
                table: "experiences",
                keyColumn: "id",
                keyValue: new Guid("cdd1f690-7871-421b-a9e3-e41e726d1a5a"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("4c10ac4e-5661-4013-aab3-0447c0052160"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("4cfcc9cf-3721-44f6-ac68-2a57ff3fb4c2"));

            migrationBuilder.DeleteData(
                table: "universities",
                keyColumn: "id",
                keyValue: new Guid("814a8376-311d-4fdb-90d2-dc411c4b5e7b"));

            migrationBuilder.RenameColumn(
                name: "job_id",
                table: "images",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_images_job_id",
                table: "images",
                newName: "IX_images_JobId");

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
                column: "DateOfBirth",
                value: new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "CreatedAt", "education_level", "field_of_study", "profile_id", "specialization", "study_from", "study_to", "university_name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("25dd644c-5b09-469a-93c3-ebfb9a1b828f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 2", "Field of Study 2", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 2", new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9897), "Vistula 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b1ac4a6-f30f-4e93-ad6f-d174fa49bfa2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor 3", "Field of Study 3", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science 3", new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9902), "Vistula 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b03043d4-c99f-49cb-aca6-b0e00328465f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor", "Field of Study", new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"), "Computer Science", new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9877), new DateTime(2024, 10, 30, 11, 9, 0, 557, DateTimeKind.Utc).AddTicks(9878), "Vistula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_images_jobs_JobId",
                table: "images",
                column: "JobId",
                principalTable: "jobs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
