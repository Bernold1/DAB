using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseContents_Courses_CourseContentId",
                table: "CourseContents");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Enrolls_EnrollId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Courses_EnrollId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EnrollId",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "EnrollId",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Enrolls",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "CourseContents",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls",
                columns: new[] { "CourseId", "StudentAuId" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentAuId", "EnrolledDate", "FirstName", "Grade", "GradulationDate", "LastName" },
                values: new object[] { 350, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bernold" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherAuId", "Birthday", "FirstName", "IsAssistant", "LastName" },
                values: new object[] { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lars", false, "Jensen" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassDateTime", "CourseName", "TeacherAuId" },
                values: new object[] { "DAB", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Databases", 1 });

            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "GroupInfoId", "GroupSize", "StudentAuId", "TeacherAuId" },
                values: new object[] { 1, 3, 350, null });

            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "AssignmentId", "AssignmentName", "CourseId", "Deadline", "RedoCounter" },
                values: new object[] { 1, "EF core", "DAB", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "CourseContents",
                columns: new[] { "CourseContentId", "ContentName", "CourseId" },
                values: new object[] { "L1", "Intro", "DAB" });

            migrationBuilder.InsertData(
                table: "Enrolls",
                columns: new[] { "CourseId", "StudentAuId" },
                values: new object[] { "DAB", 350 });

            migrationBuilder.InsertData(
                table: "GroupHandins",
                columns: new[] { "GroupHandinId", "AssignmentId", "GroupInfoId", "TeacherAuId" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CourseContents_CourseId",
                table: "CourseContents",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContents_Courses_CourseId",
                table: "CourseContents",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Courses_CourseId",
                table: "Enrolls",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseContents_Courses_CourseId",
                table: "CourseContents");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Courses_CourseId",
                table: "Enrolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_CourseContents_CourseId",
                table: "CourseContents");

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumn: "CourseContentId",
                keyValue: "L1");

            migrationBuilder.DeleteData(
                table: "Enrolls",
                keyColumns: new[] { "CourseId", "StudentAuId" },
                keyValues: new object[] { "DAB", 350 });

            migrationBuilder.DeleteData(
                table: "GroupHandins",
                keyColumn: "GroupHandinId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupsInfo",
                keyColumn: "GroupInfoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "DAB");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentAuId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherAuId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Enrolls");

            migrationBuilder.AddColumn<int>(
                name: "EnrollId",
                table: "Enrolls",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "EnrollId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "CourseContents",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls",
                column: "EnrollId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_EnrollId",
                table: "Courses",
                column: "EnrollId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContents_Courses_CourseContentId",
                table: "CourseContents",
                column: "CourseContentId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Enrolls_EnrollId",
                table: "Courses",
                column: "EnrollId",
                principalTable: "Enrolls",
                principalColumn: "EnrollId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
