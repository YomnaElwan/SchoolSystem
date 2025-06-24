using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentDeptId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudentStudId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectSubId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_StudentStudId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_SubjectSubId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentDeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentStudId",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "SubjectSubId",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubId",
                table: "StudentSubjects",
                column: "SubId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DID",
                table: "Students",
                column: "DID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DID",
                table: "Students",
                column: "DID",
                principalTable: "Departments",
                principalColumn: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudId",
                table: "StudentSubjects",
                column: "StudId",
                principalTable: "Students",
                principalColumn: "StudId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubId",
                table: "StudentSubjects",
                column: "SubId",
                principalTable: "Subjects",
                principalColumn: "SubId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_SubId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_DID",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentStudId",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectSubId",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentStudId",
                table: "StudentSubjects",
                column: "StudentStudId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectSubId",
                table: "StudentSubjects",
                column: "SubjectSubId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentDeptId",
                table: "Students",
                column: "DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentDeptId",
                table: "Students",
                column: "DepartmentDeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudentStudId",
                table: "StudentSubjects",
                column: "StudentStudId",
                principalTable: "Students",
                principalColumn: "StudId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectSubId",
                table: "StudentSubjects",
                column: "SubjectSubId",
                principalTable: "Subjects",
                principalColumn: "SubId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
