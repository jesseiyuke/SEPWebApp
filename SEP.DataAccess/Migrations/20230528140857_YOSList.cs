using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class YOSList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobPost_JobPostId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_JobPostId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "JobPost");

            migrationBuilder.AddColumn<bool>(
                name: "DepartmentCheck",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FacultyCheck",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstYear",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Graduates",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Honours",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Masters",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PhD",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Postdoc",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondYear",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdYear",
                table: "JobPost",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentCheck",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "FacultyCheck",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "FirstYear",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Graduates",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Honours",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Masters",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "PhD",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Postdoc",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "SecondYear",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "ThirdYear",
                table: "JobPost");

            migrationBuilder.AddColumn<int>(
                name: "JobPostId",
                table: "JobPost",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobPostId",
                table: "JobPost",
                column: "JobPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobPost_JobPostId",
                table: "JobPost",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id");
        }
    }
}
