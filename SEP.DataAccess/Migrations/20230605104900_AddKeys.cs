using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DepartmentId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_DriverLicense_DriversLicenseId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Gender_GenderId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Nationality_NationalityId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Race_RaceId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_YearOfStudy_YearOfStudyId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "YearOfStudyId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriversLicenseId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DepartmentId",
                table: "Student",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_DriverLicense_DriversLicenseId",
                table: "Student",
                column: "DriversLicenseId",
                principalTable: "DriverLicense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Gender_GenderId",
                table: "Student",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Nationality_NationalityId",
                table: "Student",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Race_RaceId",
                table: "Student",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_YearOfStudy_YearOfStudyId",
                table: "Student",
                column: "YearOfStudyId",
                principalTable: "YearOfStudy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DepartmentId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_DriverLicense_DriversLicenseId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Gender_GenderId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Nationality_NationalityId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Race_RaceId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_YearOfStudy_YearOfStudyId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "YearOfStudyId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DriversLicenseId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DepartmentId",
                table: "Student",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_DriverLicense_DriversLicenseId",
                table: "Student",
                column: "DriversLicenseId",
                principalTable: "DriverLicense",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Gender_GenderId",
                table: "Student",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Nationality_NationalityId",
                table: "Student",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Race_RaceId",
                table: "Student",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_YearOfStudy_YearOfStudyId",
                table: "Student",
                column: "YearOfStudyId",
                principalTable: "YearOfStudy",
                principalColumn: "Id");
        }
    }
}
