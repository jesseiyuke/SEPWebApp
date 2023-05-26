using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDriverLicenseToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriversLicense",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "DriversLicenseId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DriverLicence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicence", x => x.Id);
                });

            

            migrationBuilder.CreateIndex(
                name: "IX_Student_DriversLicenseId",
                table: "Student",
                column: "DriversLicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_DriverLicence_DriversLicenseId",
                table: "Student",
                column: "DriversLicenseId",
                principalTable: "DriverLicence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_DriverLicence_DriversLicenseId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "DriverLicence");

            migrationBuilder.DropIndex(
                name: "IX_Student_DriversLicenseId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DriversLicenseId",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "DriversLicense",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
