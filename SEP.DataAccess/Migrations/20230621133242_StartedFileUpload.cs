using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class StartedFileUpload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationDocument_StudentApplication_StudentApplicationId",
                table: "ApplicationDocument");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationDocument_StudentApplicationId",
                table: "ApplicationDocument");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "ApplicationDocument");

            migrationBuilder.DropColumn(
                name: "StudentApplicationId",
                table: "ApplicationDocument");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ApplicationDocument",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ApplicationDocument",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationDocument_ApplicationUserId",
                table: "ApplicationDocument",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationDocument_AspNetUsers_ApplicationUserId",
                table: "ApplicationDocument",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationDocument_AspNetUsers_ApplicationUserId",
                table: "ApplicationDocument");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationDocument_ApplicationUserId",
                table: "ApplicationDocument");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ApplicationDocument");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ApplicationDocument");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "ApplicationDocument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentApplicationId",
                table: "ApplicationDocument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationDocument_StudentApplicationId",
                table: "ApplicationDocument",
                column: "StudentApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationDocument_StudentApplication_StudentApplicationId",
                table: "ApplicationDocument",
                column: "StudentApplicationId",
                principalTable: "StudentApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
