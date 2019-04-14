using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class tet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                table: "GroupHandins");

            migrationBuilder.DropIndex(
                name: "IX_GroupHandins_GroupInfoId",
                table: "GroupHandins");

            migrationBuilder.DropColumn(
                name: "GroupInfoId",
                table: "GroupHandins");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentAuId", "EnrolledDate", "FirstName", "Grade", "GradulationDate", "LastName", "isActive" },
                values: new object[] { 320, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mads", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bjerg", false });

            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "GroupInfoId", "GroupId", "GroupSize", "StudentAuId", "TeacherAuId" },
                values: new object[] { 2, 1, 3, 320, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupsInfo",
                keyColumn: "GroupInfoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentAuId",
                keyValue: 320);

            migrationBuilder.AddColumn<int>(
                name: "GroupInfoId",
                table: "GroupHandins",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_GroupInfoId",
                table: "GroupHandins",
                column: "GroupInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                table: "GroupHandins",
                column: "GroupInfoId",
                principalTable: "GroupsInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
