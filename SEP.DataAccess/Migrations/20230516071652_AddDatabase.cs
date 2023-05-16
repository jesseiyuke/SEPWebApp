using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyRegNo = table.Column<long>(type: "bigint", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Cellphone = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JobPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerType = table.Column<int>(type: "int", nullable: false),
                    Faculty = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyResponsibilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobType = table.Column<int>(type: "int", nullable: false),
                    WeekHour = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HourlyRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfStudy = table.Column<int>(type: "int", nullable: false),
                    OpenTo = table.Column<int>(type: "int", nullable: false),
                    MinimumRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationInstruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<int>(type: "int", nullable: false),
                    ReviewerComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriversLicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerObjective = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YOS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Cellphone = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Cellphone = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employer");

            migrationBuilder.DropTable(
                name: "JobPost");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
