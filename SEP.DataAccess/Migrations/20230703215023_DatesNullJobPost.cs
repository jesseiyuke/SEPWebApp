using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DatesNullJobPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "JobPost",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "None South African");

            migrationBuilder.UpdateData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Honours");

            migrationBuilder.UpdateData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Graduate");

            migrationBuilder.InsertData(
                table: "YearOfStudy",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Postdoc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "JobPost",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.UpdateData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "non South African");

            migrationBuilder.UpdateData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Year 4");

            migrationBuilder.UpdateData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Honors");
        }
    }
}
