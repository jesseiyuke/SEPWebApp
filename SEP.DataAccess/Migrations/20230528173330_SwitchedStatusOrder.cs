using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SwitchedStatusOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Approved");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Pending");
        }
    }
}
