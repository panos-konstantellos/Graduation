using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class QualificationTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_QualificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DefaultName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_QualificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_QualificationTypeLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    QualificationTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_QualificationTypeLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_QualificationTypeLocalizations_edu_QualificationTypes_QualificationTypeId",
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
                });

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 1, "Πανελλήνιες Εξετάσεις" });

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 2, "Με τον ειδικό νόμο (3%) για ΑμεΑ" });

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 3, "Ομογενείς" });

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 4, "Μετεγγραφή" });

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 5, "Ειδικές Εξετάσεις" });

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 6, "Άλλο" });

            migrationBuilder.CreateIndex(
                name: "IX_edu_QualificationTypeLocalizations_LanguageId_QualificationTypeId",
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
