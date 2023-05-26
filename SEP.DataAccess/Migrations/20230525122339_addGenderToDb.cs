using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addGenderToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_DriverLicence_DriversLicenseId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DriverLicence",
                table: "DriverLicence");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "YOS",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "JobPost");

            migrationBuilder.RenameTable(
                name: "DriverLicence",
                newName: "DriverLicense");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Student",
                newName: "YearOfStudyId");

            migrationBuilder.RenameColumn(
                name: "YearOfStudy",
                table: "JobPost",
                newName: "YearOfStudyId");

            migrationBuilder.RenameColumn(
                name: "Faculty",
                table: "JobPost",
                newName: "DepartmentId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DriverLicense",
                table: "DriverLicense",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearOfStudy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearOfStudy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_DepartmentId",
                table: "Student",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GenderId",
                table: "Student",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_NationalityId",
                table: "Student",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_RaceId",
                table: "Student",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_YearOfStudyId",
                table: "Student",
                column: "YearOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_DepartmentId",
                table: "JobPost",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_YearOfStudyId",
                table: "JobPost",
                column: "YearOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_FacultyId",
                table: "Department",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_Department_DepartmentId",
                table: "JobPost",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_YearOfStudy_YearOfStudyId",
                table: "JobPost",
                column: "YearOfStudyId",
                principalTable: "YearOfStudy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_JobPost_Department_DepartmentId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_YearOfStudy_YearOfStudyId",
                table: "JobPost");

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
                name: "Department");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "YearOfStudy");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropIndex(
                name: "IX_Student_DepartmentId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_GenderId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_NationalityId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_RaceId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_YearOfStudyId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_DepartmentId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_YearOfStudyId",
                table: "JobPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DriverLicense",
                table: "DriverLicense");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "DriverLicense",
                newName: "DriverLicence");

            migrationBuilder.RenameColumn(
                name: "YearOfStudyId",
                table: "Student",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "YearOfStudyId",
                table: "JobPost",
                newName: "YearOfStudy");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "JobPost",
                newName: "Faculty");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YOS",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "JobPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DriverLicence",
                table: "DriverLicence",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_DriverLicence_DriversLicenseId",
                table: "Student",
                column: "DriversLicenseId",
                principalTable: "DriverLicence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
