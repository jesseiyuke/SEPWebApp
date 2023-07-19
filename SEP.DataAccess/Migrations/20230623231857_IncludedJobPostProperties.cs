using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class IncludedJobPostProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "StudentApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "StudentApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "StudentApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "WeekHourId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_DepartmentId",
                table: "StudentApplication",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_WeekHourId",
                table: "StudentApplication",
                column: "WeekHourId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_Department_DepartmentId",
                table: "StudentApplication",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_WeekHour_WeekHourId",
                table: "StudentApplication",
                column: "WeekHourId",
                principalTable: "WeekHour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_Department_DepartmentId",
                table: "StudentApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_WeekHour_WeekHourId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_DepartmentId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_WeekHourId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "WeekHourId",
                table: "StudentApplication");
        }
    }
}
