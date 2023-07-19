using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class StudentApplciantOutcome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "StudentApplication");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "StudentApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentApplication_StatusId",
                table: "StudentApplication",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentApplication_Status_StatusId",
                table: "StudentApplication",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentApplication_Status_StatusId",
                table: "StudentApplication");

            migrationBuilder.DropIndex(
                name: "IX_StudentApplication_StatusId",
                table: "StudentApplication");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "StudentApplication");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "StudentApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
