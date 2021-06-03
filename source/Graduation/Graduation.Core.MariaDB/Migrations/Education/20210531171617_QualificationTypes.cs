using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class QualificationTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_QualificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefaultName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_QualificationTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_QualificationTypeLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    QualificationTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_QualificationTypeLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_QualificationTypeLocalizations_edu_QualificationTypes_Qu~",
                        column: x => x.QualificationTypeId,
                        principalTable: "edu_QualificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_QualificationTypeLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[,]
                {
                    { 1, "Πανελλήνιες Εξετάσεις" },
                    { 2, "Με τον ειδικό νόμο (3%) για ΑμεΑ" },
                    { 3, "Ομογενείς" },
                    { 4, "Μετεγγραφή" },
                    { 5, "Ειδικές Εξετάσεις" },
                    { 6, "Άλλο" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_edu_QualificationTypeLocalizations_LanguageId_QualificationT~",
                table: "edu_QualificationTypeLocalizations",
                columns: new[] { "LanguageId", "QualificationTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_QualificationTypeLocalizations_QualificationTypeId",
                table: "edu_QualificationTypeLocalizations",
                column: "QualificationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edu_QualificationTypeLocalizations");

            migrationBuilder.DropTable(
                name: "edu_QualificationTypes");
        }
    }
}
