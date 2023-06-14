using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedStatusToEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Employer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employer_StatusId",
                table: "Employer",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_Status_StatusId",
                table: "Employer",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employer_Status_StatusId",
                table: "Employer");

            migrationBuilder.DropIndex(
                name: "IX_Employer_StatusId",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Employer");
        }
    }
}
