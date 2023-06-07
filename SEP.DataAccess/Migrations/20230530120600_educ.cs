using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class educ : Migration
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

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 20);

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

            migrationBuilder.AlterColumn<string>(
                name: "IdNo",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AlterColumn<string>(
                name: "CareerObjective",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Achivements",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TasksAndResponsilities = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experience_Student_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Qalificatiion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subjects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Majors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubMajors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Research = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualifications_Student_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Insitution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referees_Student_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "non South African");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_StudentId1",
                table: "Experience",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_StudentId1",
                table: "Qualifications",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_StudentId1",
                table: "Referees",
                column: "StudentId1");

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

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Referees");

            migrationBuilder.DropColumn(
                name: "Achivements",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Skills",
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

            migrationBuilder.AlterColumn<string>(
                name: "IdNo",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.AlterColumn<string>(
                name: "CareerObjective",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "British");

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Dutch" },
                    { 4, "Indian" },
                    { 5, "Chinese" },
                    { 6, "Portuguese" },
                    { 7, "German" },
                    { 8, "Zimbabwean" },
                    { 9, "Mozambican" },
                    { 10, "Namibian" },
                    { 11, "Congolese" },
                    { 12, "Malawian" },
                    { 13, "Zambian" },
                    { 14, "Nigerian" },
                    { 15, "Ghanaian" },
                    { 16, "Tanzanian" },
                    { 17, "Kenyan" },
                    { 18, "Ugandan" },
                    { 19, "Ethiopian" },
                    { 20, "Somali" }
                });

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
    }
}
