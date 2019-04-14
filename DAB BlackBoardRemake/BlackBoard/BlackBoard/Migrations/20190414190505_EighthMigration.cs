using System;
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
                value: 10);

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "GroupInfoId",
                keyValue: 1,
                column: "GroupId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentAuId", "EnrolledDate", "FirstName", "Grade", "GradulationDate", "LastName", "isActive" },
                values: new object[] { 320, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mads", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bjerg", false });

            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "GroupInfoId", "GroupId", "GroupSize", "StudentAuId", "TeacherAuId" },
                values: new object[] { 2, 3, 3, 320, null });
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

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "GroupHandins");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "GroupInfoId",
                keyValue: 1,
                column: "GroupId",
                value: 1);
        }
    }
}
