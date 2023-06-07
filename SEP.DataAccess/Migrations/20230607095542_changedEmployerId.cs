using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changedEmployerId : Migration
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

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_AspNetUsers_Id",
                table: "Employer",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employer_AspNetUsers_Id",
                table: "Employer");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Employer",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Employer_ApplicationUserId",
                table: "Employer",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_AspNetUsers_ApplicationUserId",
                table: "Employer",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
