using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_AspNetUsers_ApplicationUserId",
                table: "JobPost");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "JobPost",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_AspNetUsers_ApplicationUserId",
                table: "JobPost",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_AspNetUsers_ApplicationUserId",
                table: "JobPost");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "JobPost",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_AspNetUsers_ApplicationUserId",
                table: "JobPost",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
