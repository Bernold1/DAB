using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "GroupsInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                });

            migrationBuilder.InsertData(
                table: "Group",
                column: "GroupId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "GroupInfoId",
                keyValue: 1,
                column: "GroupId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_GroupsInfo_GroupId",
                table: "GroupsInfo",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupsInfo_Group_GroupId",
                table: "GroupsInfo",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupsInfo_Group_GroupId",
                table: "GroupsInfo");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropIndex(
                name: "IX_GroupsInfo_GroupId",
                table: "GroupsInfo");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "GroupsInfo");
        }
    }
}
