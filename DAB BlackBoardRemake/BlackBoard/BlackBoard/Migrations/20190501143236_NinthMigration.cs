using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class NinthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "GroupHandins",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "GroupHandins",
                keyColumn: "GroupHandinId",
                keyValue: 1,
                column: "Grade",
                value: 7.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "GroupHandins",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "GroupHandins",
                keyColumn: "GroupHandinId",
                keyValue: 1,
                column: "Grade",
                value: 7);
        }
    }
}
