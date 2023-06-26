using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentDetailsToApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearOfStudyId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_FacultyId",
                table: "StudentApplication",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_GenderId",
                table: "StudentApplication",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_NationalityId",
                table: "StudentApplication",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_YearOfStudyId",
                table: "StudentApplication",
                column: "YearOfStudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_Faculty_FacultyId",
                table: "StudentApplication",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_Gender_GenderId",
                table: "StudentApplication",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_Nationality_NationalityId",
                table: "StudentApplication",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_YearOfStudy_YearOfStudyId",
                table: "StudentApplication",
                column: "YearOfStudyId",
                principalTable: "YearOfStudy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_Faculty_FacultyId",
                table: "StudentApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_Gender_GenderId",
                table: "StudentApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_Nationality_NationalityId",
                table: "StudentApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_YearOfStudy_YearOfStudyId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_FacultyId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_GenderId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_NationalityId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_YearOfStudyId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "YearOfStudyId",
                table: "StudentApplication");
        }
    }
}
