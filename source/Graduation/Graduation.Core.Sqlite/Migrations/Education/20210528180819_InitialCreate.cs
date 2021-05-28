using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sys_Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_DepartmentLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_DepartmentLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_DepartmentLocalizations_edu_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "edu_Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_DepartmentLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_edu_DepartmentLocalizations_DepartmentId",
                table: "edu_DepartmentLocalizations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_DepartmentLocalizations_LanguageId",
                table: "edu_DepartmentLocalizations",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edu_DepartmentLocalizations");

            migrationBuilder.DropTable(
                name: "edu_Departments");

            migrationBuilder.DropTable(
                name: "sys_Languages");
        }
    }
}
