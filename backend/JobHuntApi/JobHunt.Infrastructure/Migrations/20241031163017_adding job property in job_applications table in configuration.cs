using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobHunt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingjobpropertyinjob_applicationstableinconfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_job_applications_jobs_JobId1",
                table: "job_applications");

            migrationBuilder.DropIndex(
                name: "IX_job_applications_JobId1",
                table: "job_applications");

            migrationBuilder.DropColumn(
                name: "JobId1",
                table: "job_applications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "JobId1",
                table: "job_applications",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_job_applications_JobId1",
                table: "job_applications",
                column: "JobId1");

            migrationBuilder.AddForeignKey(
                name: "FK_job_applications_jobs_JobId1",
                table: "job_applications",
                column: "JobId1",
                principalTable: "jobs",
                principalColumn: "id");
        }
    }
}
