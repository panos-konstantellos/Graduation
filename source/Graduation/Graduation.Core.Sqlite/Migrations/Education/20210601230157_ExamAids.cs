using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class ExamAids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_ExamAids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultTitle = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_ExamAids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_ExamAidLocalization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExamAidid = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_ExamAidLocalization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_ExamAidLocalization_edu_ExamAids_ExamAidid",
                        column: x => x.ExamAidid,
                        principalTable: "edu_ExamAids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_ExamAidLocalization_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "edu_DisabilityAids",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "HearingAid");

            migrationBuilder.InsertData(
                table: "edu_ExamAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 1, "oralExams", null, "προφορικές εξετάσεις" });

            migrationBuilder.InsertData(
                table: "edu_ExamAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 2, "differentQuestions", null, "διαφορετικά θέματα" });

            migrationBuilder.InsertData(
                table: "edu_ExamAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 3, "braille", null, "με χρήση της γραφής Braille" });

            migrationBuilder.InsertData(
                table: "edu_ExamAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 4, "computer", null, "με χρήση Η/Υ" });

            migrationBuilder.CreateIndex(
                name: "IX_edu_ExamAidLocalization_ExamAidid",
                table: "edu_ExamAidLocalization",
                column: "ExamAidid");

            migrationBuilder.CreateIndex(
                name: "IX_edu_ExamAidLocalization_LanguageId_ExamAidid",
                table: "edu_ExamAidLocalization",
                columns: new[] { "LanguageId", "ExamAidid" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edu_ExamAidLocalization");

            migrationBuilder.DropTable(
                name: "edu_ExamAids");

            migrationBuilder.UpdateData(
                table: "edu_DisabilityAids",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "hearing");
        }
    }
}
