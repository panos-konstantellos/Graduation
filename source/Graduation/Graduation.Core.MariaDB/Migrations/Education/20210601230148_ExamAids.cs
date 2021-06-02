using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class ExamAids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_ExamAids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultTitle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_ExamAids", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_ExamAidLocalization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ExamAidid = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "edu_DisabilityAids",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "HearingAid");

            migrationBuilder.InsertData(
                table: "edu_ExamAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[,]
                {
                    { 1, "oralExams", null, "προφορικές εξετάσεις" },
                    { 2, "differentQuestions", null, "διαφορετικά θέματα" },
                    { 3, "braille", null, "με χρήση της γραφής Braille" },
                    { 4, "computer", null, "με χρήση Η/Υ" }
                });

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
