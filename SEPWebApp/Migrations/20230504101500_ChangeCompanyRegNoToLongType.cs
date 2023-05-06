using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEPWebApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCompanyRegNoToLongType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CompanyRegNo",
                table: "Employers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CompanyRegNo",
                table: "Employers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
