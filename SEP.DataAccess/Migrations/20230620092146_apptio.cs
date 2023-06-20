using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class apptio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_Department_DepartmentId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_Faculty_FacultyId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_DepartmentId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_FacultyId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "JobPost");

            migrationBuilder.AddColumn<int>(
                name: "JobPostId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_JobPostId",
                table: "StudentApplication",
                column: "JobPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_JobPost_JobPostId",
                table: "StudentApplication",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_JobPost_JobPostId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_JobPostId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "StudentApplication");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "JobPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "JobPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_DepartmentId",
                table: "JobPost",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_FacultyId",
                table: "JobPost",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_Department_DepartmentId",
                table: "JobPost",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_Faculty_FacultyId",
                table: "JobPost",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
