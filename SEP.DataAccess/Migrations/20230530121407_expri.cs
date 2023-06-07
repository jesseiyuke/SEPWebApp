using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class expri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Student_StudentId1",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Student_StudentId1",
                table: "Qualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Student_StudentId1",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Referees_StudentId1",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_StudentId1",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Experience_StudentId1",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Referees");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Experience");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Referees",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Qualifications",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Experience",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_StudentId",
                table: "Referees",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_StudentId",
                table: "Qualifications",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_StudentId",
                table: "Experience",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Student_StudentId",
                table: "Experience",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Student_StudentId",
                table: "Qualifications",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referees_Student_StudentId",
                table: "Referees",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Student_StudentId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Student_StudentId",
                table: "Qualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Student_StudentId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Referees_StudentId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_StudentId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Experience_StudentId",
                table: "Experience");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Referees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "Referees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Qualifications",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "Qualifications",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Experience",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "Experience",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_StudentId1",
                table: "Referees",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_StudentId1",
                table: "Qualifications",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_StudentId1",
                table: "Experience",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Student_StudentId1",
                table: "Experience",
                column: "StudentId1",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Student_StudentId1",
                table: "Qualifications",
                column: "StudentId1",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referees_Student_StudentId1",
                table: "Referees",
                column: "StudentId1",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
