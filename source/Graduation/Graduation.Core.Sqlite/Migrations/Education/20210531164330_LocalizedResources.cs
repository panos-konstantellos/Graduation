using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class LocalizedResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.CreateTable(
                name: "sys_LocalizedResources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_LocalizedResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sys_LocalizedResources_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sys_LocalizedResources_LanguageId_Key",
                table: "sys_LocalizedResources",
                columns: new[] { "LanguageId", "Key" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_LocalizedResources");

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 34, "ny", "Chichewa" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 38, "cu", "Church Slavonic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 141, "ny", "Nyanja" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 146, "cu", "Old Bulgarian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 147, "cu", "Old Church Slavonic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 148, "cu", "Old Slavonic" });
        }
    }
}
