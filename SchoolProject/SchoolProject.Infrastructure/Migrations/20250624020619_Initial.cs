using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DID = table.Column<int>(type: "int", nullable: true),
                    DepartmentDeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudId);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentDeptId",
                        column: x => x.DepartmentDeptId,
                        principalTable: "Departments",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentSubjects",
                columns: table => new
                {
                    SubId = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    SubjectSubId = table.Column<int>(type: "int", nullable: false),
                    DepartmentDeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentSubjects", x => new { x.DeptId, x.SubId });
                    table.ForeignKey(
                        name: "FK_DepartmentSubjects_Departments_DepartmentDeptId",
                        column: x => x.DepartmentDeptId,
                        principalTable: "Departments",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentSubjects_Subjects_SubjectSubId",
                        column: x => x.SubjectSubId,
                        principalTable: "Subjects",
                        principalColumn: "SubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    StudId = table.Column<int>(type: "int", nullable: false),
                    SubId = table.Column<int>(type: "int", nullable: false),
                    StudentStudId = table.Column<int>(type: "int", nullable: false),
                    SubjectSubId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => new { x.StudId, x.SubId });
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_StudentStudId",
                        column: x => x.StudentStudId,
                        principalTable: "Students",
                        principalColumn: "StudId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Subjects_SubjectSubId",
                        column: x => x.SubjectSubId,
                        principalTable: "Subjects",
                        principalColumn: "SubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubjects_DepartmentDeptId",
                table: "DepartmentSubjects",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubjects_SubjectSubId",
                table: "DepartmentSubjects",
                column: "SubjectSubId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentDeptId",
                table: "Students",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentStudId",
                table: "StudentSubjects",
                column: "StudentStudId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectSubId",
                table: "StudentSubjects",
                column: "SubjectSubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentSubjects");

            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
