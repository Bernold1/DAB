using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class EighthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "GroupHandins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GroupHandins",
                keyColumn: "GroupHandinId",
                keyValue: 1,
                column: "Grade",
                value: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "GroupHandins");
        }
    }
}
