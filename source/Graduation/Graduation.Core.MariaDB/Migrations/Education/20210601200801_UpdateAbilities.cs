using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class UpdateAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "edu_Abilities",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "vision");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "hearing");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "speech");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "stretching");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: "dexterity");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Code",
                value: "movement");

            migrationBuilder.UpdateData(
                table: "edu_Abilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Code",
                value: "understanding");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "edu_Abilities");
        }
    }
}
