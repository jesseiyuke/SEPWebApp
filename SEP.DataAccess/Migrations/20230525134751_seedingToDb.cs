using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "South African" },
                    { 2, "British" },
                    { 3, "Dutch" },
                    { 4, "Indian" },
                    { 5, "Chinese" },
                    { 6, "Portuguese" },
                    { 7, "German" },
                    { 8, "Zimbabwean" },
                    { 9, "Mozambican" },
                    { 10, "Namibian" },
                    { 11, "Congolese" },
                    { 12, "Malawian" },
                    { 13, "Zambian" },
                    { 14, "Nigerian" },
                    { 15, "Ghanaian" },
                    { 16, "Tanzanian" },
                    { 17, "Kenyan" },
                    { 18, "Ugandan" },
                    { 19, "Ethiopian" },
                    { 20, "Somali" }
                });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "African" },
                    { 2, "Coloured" },
                    { 3, "Indian" },
                    { 4, "White" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "YearOfStudy",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Year 1" },
                    { 2, "Year 2" },
                    { 3, "Year 3" },
                    { 4, "Year 4" },
                    { 5, "Honors" },
                    { 6, "Master's" },
                    { 7, "PhD" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Race",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "YearOfStudy",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
