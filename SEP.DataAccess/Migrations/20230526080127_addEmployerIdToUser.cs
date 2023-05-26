using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addEmployerIdToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employer_AspNetUsers_ApplicationUserId",
                table: "Employer");

            migrationBuilder.DropIndex(
                name: "IX_Employer_ApplicationUserId",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Employer");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployerId",
                table: "AspNetUsers",
                column: "EmployerId",
                unique: true,
                filter: "[EmployerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employer_EmployerId",
                table: "AspNetUsers",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employer_EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Employer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employer_ApplicationUserId",
                table: "Employer",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_AspNetUsers_ApplicationUserId",
                table: "Employer",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
