using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangedJobTypeList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobTypeId",
                table: "WeekHour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "WeekHour",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "WeekHour",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "WeekHour",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "WeekHour",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "WeekHour",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobTypeId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_WeekHour_JobTypeId",
                table: "WeekHour",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekHour_JobType_JobTypeId",
                table: "WeekHour",
                column: "JobTypeId",
                principalTable: "JobType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeekHour_JobType_JobTypeId",
                table: "WeekHour");

            migrationBuilder.DropIndex(
                name: "IX_WeekHour_JobTypeId",
                table: "WeekHour");

            migrationBuilder.DropColumn(
                name: "JobTypeId",
                table: "WeekHour");
        }
    }
}
