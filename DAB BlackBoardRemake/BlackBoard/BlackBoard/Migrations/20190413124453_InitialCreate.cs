using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentAuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    EnrolledDate = table.Column<DateTime>(nullable: false),
                    GradulationDate = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentAuId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherAuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IsAssistant = table.Column<bool>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherAuId);
                });

            migrationBuilder.CreateTable(
                name: "Enrolls",
                columns: table => new
                {
                    EnrollId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentAuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolls", x => x.EnrollId);
                    table.ForeignKey(
                        name: "FK_Enrolls_Students_StudentAuId",
                        column: x => x.StudentAuId,
                        principalTable: "Students",
                        principalColumn: "StudentAuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupsInfo",
                columns: table => new
                {
                    GroupInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupSize = table.Column<int>(nullable: false),
                    StudentAuId = table.Column<int>(nullable: false),
                    TeacherAuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsInfo", x => x.GroupInfoId);
                    table.ForeignKey(
                        name: "FK_GroupsInfo_Students_StudentAuId",
                        column: x => x.StudentAuId,
                        principalTable: "Students",
                        principalColumn: "StudentAuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsInfo_Teachers_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherAuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: false),
                    ClassDateTime = table.Column<DateTime>(nullable: false),
                    EnrollId = table.Column<int>(nullable: false),
                    TeacherAuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Enrolls_EnrollId",
                        column: x => x.EnrollId,
                        principalTable: "Enrolls",
                        principalColumn: "EnrollId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherAuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentName = table.Column<string>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    RedoCounter = table.Column<int>(nullable: false),
                    CourseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.AssignmentId);
                    table.ForeignKey(
                        name: "FK_Assignment_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseContents",
                columns: table => new
                {
                    CourseContentId = table.Column<string>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseContents", x => x.CourseContentId);
                    table.ForeignKey(
                        name: "FK_CourseContents_Courses_CourseContentId",
                        column: x => x.CourseContentId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupHandins",
                columns: table => new
                {
                    GroupHandinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<int>(nullable: false),
                    GroupInfoId = table.Column<int>(nullable: false),
                    TeacherAuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupHandins", x => x.GroupHandinId);
                    table.ForeignKey(
                        name: "FK_GroupHandins_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupHandins_GroupsInfo_GroupInfoId",
                        column: x => x.GroupInfoId,
                        principalTable: "GroupsInfo",
                        principalColumn: "GroupInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupHandins_Teachers_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherAuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_EnrollId",
                table: "Courses",
                column: "EnrollId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherAuId",
                table: "Courses",
                column: "TeacherAuId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_StudentAuId",
                table: "Enrolls",
                column: "StudentAuId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_AssignmentId",
                table: "GroupHandins",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_GroupInfoId",
                table: "GroupHandins",
                column: "GroupInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_TeacherAuId",
                table: "GroupHandins",
                column: "TeacherAuId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsInfo_StudentAuId",
                table: "GroupsInfo",
                column: "StudentAuId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsInfo_TeacherAuId",
                table: "GroupsInfo",
                column: "TeacherAuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseContents");

            migrationBuilder.DropTable(
                name: "GroupHandins");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "GroupsInfo");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Enrolls");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
