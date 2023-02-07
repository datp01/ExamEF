using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace practive.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", maxLength: 100, nullable: false),
                    StudentId = table.Column<long>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    ExamsExamId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Exams_ExamsExamId",
                        column: x => x.ExamsExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId");
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubjectName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    SubjectCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExamsExamId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Exams_ExamsExamId",
                        column: x => x.ExamsExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId");
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "ExamId", "Score", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1L, 70, 1L, 1 },
                    { 2L, 50, 2L, 2 },
                    { 3L, 70, 3L, 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address", "DateOfBirth", "Email", "ExamsExamId", "Name" },
                values: new object[,]
                {
                    { 1L, "Ha Noi", new DateTime(2003, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "dat1@gmail.com", null, "Tien Dat" },
                    { 2L, "Ha Noi", new DateTime(2003, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "anh1@gmail.com", null, "Tien Anh" },
                    { 3L, "Ha Noi", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "dung1@gmail.com", null, "Tien Dung" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Description", "EndDate", "ExamsExamId", "StartDate", "SubjectCode", "SubjectName" },
                values: new object[,]
                {
                    { 1, "Mon toan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "T01", "Toan" },
                    { 2, "Mon Van", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "V01", "Van" },
                    { 3, "Mon English", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A01", "Anh" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ExamsExamId",
                table: "Students",
                column: "ExamsExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ExamsExamId",
                table: "Subjects",
                column: "ExamsExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
