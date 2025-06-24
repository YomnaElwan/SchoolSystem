using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubjects_Departments_DepartmentDeptId",
                table: "DepartmentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubjects_Subjects_SubjectSubId",
                table: "DepartmentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentSubjects_DepartmentDeptId",
                table: "DepartmentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentSubjects_SubjectSubId",
                table: "DepartmentSubjects");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "DepartmentSubjects");

            migrationBuilder.DropColumn(
                name: "SubjectSubId",
                table: "DepartmentSubjects");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubjects_SubId",
                table: "DepartmentSubjects",
                column: "SubId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubjects_Departments_DeptId",
                table: "DepartmentSubjects",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubjects_Subjects_SubId",
                table: "DepartmentSubjects",
                column: "SubId",
                principalTable: "Subjects",
                principalColumn: "SubId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubjects_Departments_DeptId",
                table: "DepartmentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubjects_Subjects_SubId",
                table: "DepartmentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentSubjects_SubId",
                table: "DepartmentSubjects");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "DepartmentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectSubId",
                table: "DepartmentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubjects_DepartmentDeptId",
                table: "DepartmentSubjects",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubjects_SubjectSubId",
                table: "DepartmentSubjects",
                column: "SubjectSubId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubjects_Departments_DepartmentDeptId",
                table: "DepartmentSubjects",
                column: "DepartmentDeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubjects_Subjects_SubjectSubId",
                table: "DepartmentSubjects",
                column: "SubjectSubId",
                principalTable: "Subjects",
                principalColumn: "SubId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
