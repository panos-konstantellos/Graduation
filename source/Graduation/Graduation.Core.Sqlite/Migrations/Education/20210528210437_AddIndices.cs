using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class AddIndices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_edu_DepartmentLocalizations_DepartmentId",
                table: "edu_DepartmentLocalizations");

            migrationBuilder.CreateIndex(
                name: "IX_sys_Languages_Code",
                table: "sys_Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_Departments_Code",
                table: "edu_Departments",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_DepartmentLocalizations_DepartmentId_LanguageId",
                table: "edu_DepartmentLocalizations",
                columns: new[] { "DepartmentId", "LanguageId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_sys_Languages_Code",
                table: "sys_Languages");

            migrationBuilder.DropIndex(
                name: "IX_edu_Departments_Code",
                table: "edu_Departments");

            migrationBuilder.DropIndex(
                name: "IX_edu_DepartmentLocalizations_DepartmentId_LanguageId",
                table: "edu_DepartmentLocalizations");

            migrationBuilder.CreateIndex(
                name: "IX_edu_DepartmentLocalizations_DepartmentId",
                table: "edu_DepartmentLocalizations",
                column: "DepartmentId");
        }
    }
}
