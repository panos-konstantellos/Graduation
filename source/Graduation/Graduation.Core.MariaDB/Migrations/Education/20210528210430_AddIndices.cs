using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class AddIndices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "sys_Languages",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "edu_Departments",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "sys_Languages",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "edu_Departments",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_edu_DepartmentLocalizations_DepartmentId",
                table: "edu_DepartmentLocalizations",
                column: "DepartmentId");
        }
    }
}
