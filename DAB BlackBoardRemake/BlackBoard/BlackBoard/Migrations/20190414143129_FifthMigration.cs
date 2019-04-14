using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Courses_CourseId",
                table: "Enrolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls");

            migrationBuilder.DeleteData(
                table: "Enrolls",
                keyColumns: new[] { "CourseId", "StudentAuId" },
                keyValues: new object[] { "DAB", 350 });

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Enrolls",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "EnrollId",
                table: "Enrolls",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls",
                column: "EnrollId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_CourseId",
                table: "Enrolls",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Courses_CourseId",
                table: "Enrolls",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Courses_CourseId",
                table: "Enrolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_CourseId",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "EnrollId",
                table: "Enrolls");

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Enrolls",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrolls",
                table: "Enrolls",
                columns: new[] { "CourseId", "StudentAuId" });

            migrationBuilder.InsertData(
                table: "Enrolls",
                columns: new[] { "CourseId", "StudentAuId" },
                values: new object[] { "DAB", 350 });

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Courses_CourseId",
                table: "Enrolls",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
