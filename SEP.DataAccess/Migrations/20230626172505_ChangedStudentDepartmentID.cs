using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangedStudentDepartmentID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentDepartmentId",
                table: "StudentApplication",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_StudentDepartmentId",
                table: "StudentApplication",
                column: "StudentDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_Department_StudentDepartmentId",
                table: "StudentApplication",
                column: "StudentDepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_Department_StudentDepartmentId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_StudentDepartmentId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "StudentDepartmentId",
                table: "StudentApplication");
        }
    }
}
