using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class businessTypeList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessType",
                table: "Employer");

            migrationBuilder.AddColumn<int>(
                name: "BusinessTypeId",
                table: "Employer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BusinessType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BusinessType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sole Proprietorship" },
                    { 2, "Partnership" },
                    { 3, "Pty Ltd - Proprietary limited company" },
                    { 4, "Public Company" },
                    { 5, "Private Company" },
                    { 6, "State Owned Companies" },
                    { 7, "Non-profit Company" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employer_BusinessTypeId",
                table: "Employer",
                column: "BusinessTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_BusinessType_BusinessTypeId",
                table: "Employer",
                column: "BusinessTypeId",
                principalTable: "BusinessType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employer_BusinessType_BusinessTypeId",
                table: "Employer");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropIndex(
                name: "IX_Employer_BusinessTypeId",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "BusinessTypeId",
                table: "Employer");

            migrationBuilder.AddColumn<string>(
                name: "BusinessType",
                table: "Employer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
