using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pupil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: false),
                    Class = table.Column<string>(type: "TEXT", nullable: false),
                    TeachedId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherPupil",
                columns: table => new
                {
                    PupilId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPupil", x => new { x.PupilId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_TeacherPupil_Pupil_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherPupil_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 1, "5A", "Smith", "Alice", "Female", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 2, "5A", "Johnson", "Bob", "Male", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 3, "5B", "Williams", "Charlie", "Male", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 4, "5B", "Miller", "Diana", "Female", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 5, "5C", "Brown", "Emily", "Female", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 6, "5C", "Davis", "Frank", "Male", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 7, "5D", "Garcia", "Grace", "Female", 0 });

            migrationBuilder.InsertData(
                table: "Pupil",
                columns: new[] { "Id", "Class", "LastName", "Name", "Sex", "TeachedId" },
                values: new object[] { 8, "5D", "Taylor", "Henry", "Male", 0 });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "LastName", "Name", "Sex", "Subject" },
                values: new object[] { 1, "Doe", "John", "Male", "Math" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "LastName", "Name", "Sex", "Subject" },
                values: new object[] { 2, "Doe", "Jane", "Female", "English" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "LastName", "Name", "Sex", "Subject" },
                values: new object[] { 3, "Smith", "Bob", "Male", "Science" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "LastName", "Name", "Sex", "Subject" },
                values: new object[] { 4, "Johnson", "Mary", "Female", "History" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "LastName", "Name", "Sex", "Subject" },
                values: new object[] { 5, "Williams", "Tom", "Male", "Art" });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 5, 3 });

            migrationBuilder.InsertData(
                table: "TeacherPupil",
                columns: new[] { "PupilId", "TeacherId" },
                values: new object[] { 5, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherPupil_TeacherId",
                table: "TeacherPupil",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherPupil");

            migrationBuilder.DropTable(
                name: "Pupil");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
