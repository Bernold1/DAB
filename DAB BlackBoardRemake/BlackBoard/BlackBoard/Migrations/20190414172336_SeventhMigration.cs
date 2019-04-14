using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                table: "GroupHandins");

            migrationBuilder.AlterColumn<int>(
                name: "GroupInfoId",
                table: "GroupHandins",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "GroupHandins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GroupHandins",
                keyColumn: "GroupHandinId",
                keyValue: 1,
                columns: new[] { "GroupId", "GroupInfoId" },
                values: new object[] { 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_GroupId",
                table: "GroupHandins",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupHandins_Group_GroupId",
                table: "GroupHandins",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                table: "GroupHandins",
                column: "GroupInfoId",
                principalTable: "GroupsInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupHandins_Group_GroupId",
                table: "GroupHandins");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                table: "GroupHandins");

            migrationBuilder.DropIndex(
                name: "IX_GroupHandins_GroupId",
                table: "GroupHandins");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "GroupHandins");

            migrationBuilder.AlterColumn<int>(
                name: "GroupInfoId",
                table: "GroupHandins",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "GroupHandins",
                keyColumn: "GroupHandinId",
                keyValue: 1,
                column: "GroupInfoId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                table: "GroupHandins",
                column: "GroupInfoId",
                principalTable: "GroupsInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
