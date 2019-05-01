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
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: false),
                    ClassDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

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
                    Grade = table.Column<double>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
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
                    CourseContentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentName = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseContents", x => x.CourseContentId);
                    table.ForeignKey(
                        name: "FK_CourseContents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrolls",
                columns: table => new
                {
                    EnrollId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<string>(nullable: true),
                    StudentAuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolls", x => x.EnrollId);
                    table.ForeignKey(
                        name: "FK_Enrolls_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrolls_Students_StudentAuId",
                        column: x => x.StudentAuId,
                        principalTable: "Students",
                        principalColumn: "StudentAuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseManagement",
                columns: table => new
                {
                    CourseManagementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CouseId = table.Column<string>(nullable: true),
                    TeacherAuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseManagement", x => x.CourseManagementId);
                    table.ForeignKey(
                        name: "FK_CourseManagement_Courses_CouseId",
                        column: x => x.CouseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseManagement_Teachers_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherAuId",
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
                    GroupId = table.Column<int>(nullable: false),
                    TeacherAuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsInfo", x => x.GroupInfoId);
                    table.ForeignKey(
                        name: "FK_GroupsInfo_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "GroupHandins",
                columns: table => new
                {
                    GroupHandinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<int>(nullable: false),
                    Grade = table.Column<double>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
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
                        name: "FK_GroupHandins_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupHandins_Teachers_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherAuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassDateTime", "CourseName" },
                values: new object[,]
                {
                    { "DAB", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Databases" },
                    { "IKN", new DateTime(2016, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Network communication" },
                    { "ISU", new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embedded software development" }
                });

            migrationBuilder.InsertData(
                table: "Group",
                column: "GroupId",
                values: new object[]
                {
                    10,
                    8,
                    7,
                    9,
                    5,
                    1,
                    6
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentAuId", "EnrolledDate", "FirstName", "Grade", "GradulationDate", "LastName", "isActive" },
                values: new object[,]
                {
                    { 350, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bernold", false },
                    { 320, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mads", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bjerg", false },
                    { 330, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harold", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nyborg", false },
                    { 340, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jens", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flix", false },
                    { 360, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bill", 8.3000000000000007, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka", false }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherAuId", "Birthday", "FirstName", "IsAssistant", "LastName" },
                values: new object[,]
                {
                    { 3, new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karen", false, "Blixen" },
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lars", false, "Jensen" },
                    { 10, new DateTime(1960, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", false, "Rasmussen" }
                });

            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "AssignmentId", "AssignmentName", "CourseId", "Deadline", "RedoCounter" },
                values: new object[,]
                {
                    { 1, "EF core", "DAB", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "TCP", "IKN", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Mutexes", "ISU", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "CourseContents",
                columns: new[] { "CourseContentId", "ContentName", "CourseId" },
                values: new object[,]
                {
                    { 1, "Intro", "DAB" },
                    { 2, "EF core", "DAB" },
                    { 3, "Intro", "IKN" },
                    { 4, "HTTP", "IKN" },
                    { 5, "Intro", "ISU" },
                    { 6, "Threads", "ISU" }
                });

            migrationBuilder.InsertData(
                table: "CourseManagement",
                columns: new[] { "CourseManagementId", "CouseId", "TeacherAuId" },
                values: new object[,]
                {
                    { 3, "ISU", 1 },
                    { 1, "IKN", 1 },
                    { 2, "IKN", 3 },
                    { 4, "DAB", 10 }
                });

            migrationBuilder.InsertData(
                table: "Enrolls",
                columns: new[] { "EnrollId", "CourseId", "StudentAuId" },
                values: new object[,]
                {
                    { 2, "DAB", 330 },
                    { 6, "IKN", 330 },
                    { 4, "DAB", 340 },
                    { 8, "IKN", 340 },
                    { 9, "ISU", 360 },
                    { 5, "IKN", 350 },
                    { 1, "DAB", 350 },
                    { 3, "DAB", 320 },
                    { 7, "IKN", 320 }
                });

            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "GroupInfoId", "GroupId", "GroupSize", "StudentAuId", "TeacherAuId" },
                values: new object[,]
                {
                    { 1, 1, 3, 350, null },
                    { 3, 1, 3, 320, null },
                    { 2, 1, 3, 330, null },
                    { 5, 10, 1, 340, null },
                    { 4, 9, 1, 360, null }
                });

            migrationBuilder.InsertData(
                table: "GroupHandins",
                columns: new[] { "GroupHandinId", "AssignmentId", "Grade", "GroupId", "TeacherAuId" },
                values: new object[] { 1, 1, 12.0, 1, 1 });

            migrationBuilder.InsertData(
                table: "GroupHandins",
                columns: new[] { "GroupHandinId", "AssignmentId", "Grade", "GroupId", "TeacherAuId" },
                values: new object[] { 2, 1, 4.0, 9, 10 });

            migrationBuilder.InsertData(
                table: "GroupHandins",
                columns: new[] { "GroupHandinId", "AssignmentId", "Grade", "GroupId", "TeacherAuId" },
                values: new object[] { 3, 1, 2.0, 10, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseContents_CourseId",
                table: "CourseContents",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseManagement_CouseId",
                table: "CourseManagement",
                column: "CouseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseManagement_TeacherAuId",
                table: "CourseManagement",
                column: "TeacherAuId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_CourseId",
                table: "Enrolls",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_StudentAuId",
                table: "Enrolls",
                column: "StudentAuId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_AssignmentId",
                table: "GroupHandins",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_GroupId",
                table: "GroupHandins",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupHandins_TeacherAuId",
                table: "GroupHandins",
                column: "TeacherAuId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsInfo_GroupId",
                table: "GroupsInfo",
                column: "GroupId");

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
                name: "CourseManagement");

            migrationBuilder.DropTable(
                name: "Enrolls");

            migrationBuilder.DropTable(
                name: "GroupHandins");

            migrationBuilder.DropTable(
                name: "GroupsInfo");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
