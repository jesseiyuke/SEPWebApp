using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedDriverLicense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DriverLicense",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A - MotorCycle" },
                    { 2, "A1 - Light MotorCycle" },
                    { 3, "B - Light Motor Vehicle" },
                    { 4, "C - Heavy Motor Vehicle" },
                    { 5, "C1 - Light Heavy Motor Vehicle" },
                    { 6, "EB - Ligth Motor Vehicle + Trailer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DriverLicense",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DriverLicense",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DriverLicense",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DriverLicense",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DriverLicense",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DriverLicense",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
