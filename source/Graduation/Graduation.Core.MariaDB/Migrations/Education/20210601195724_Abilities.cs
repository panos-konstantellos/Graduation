using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class Abilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "edu_QualificationTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.CreateTable(
                name: "edu_Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefaultTitle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_Abilities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_AbilityLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_AbilityLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_AbilityLocalizations_edu_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "edu_Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_AbilityLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "edu_Abilities",
                columns: new[] { "Id", "DefaultDescription", "DefaultTitle" },
                values: new object[,]
                {
                    { 1, "η ικανότητα ενός ατόμου να αναγνωρίζει και να διαβάζει χωρίς τη χρήση τεχνολογίας.", "Όραση" },
                    { 2, "η ικανότητα του ατόμου να ακούει κάποιο συνομιλητή και να αντιλαμβάνεται ακουστικά σήματα.", "Ακοή" },
                    { 3, "η δυνατότητα του ατόμου να ομιλεί με κάποιο συνομιλητή.", "Ομιλία" },
                    { 4, "η δυνατότητα του ατόμου να εκτελεί αυτές τις ενέργειες με το επάνω μέρος του σώματος έχοντας ταυτόχρονα καλό έλεγχο της δύναμής του.", "Τέντωμα και Φτάσιμο" },
                    { 5, "η ικανότητα του ατόμου να πιάνει κάτι, να κρατάει κάτι, να μεταφέρει, να στριφογυρίζει κάτι και να γράφει.", "Επιδεξιότητα" },
                    { 6, "η ικανότητα ενός ατόμου για βηματισμό, να ανεβαίνει σκάλες, για σκαρφάλωμα, για σκύψιμο και για ισορροπία, χωρίς τη χρήση βοηθημάτων.	", "Μετακίνηση" },
                    { 7, "η δυνατότητα του ατόμου για κατανόηση του προφορικού και γραπτού λόγου.", "Κατανόηση" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_edu_AbilityLocalizations_AbilityId",
                table: "edu_AbilityLocalizations",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_AbilityLocalizations_LanguageId_AbilityId",
                table: "edu_AbilityLocalizations",
                columns: new[] { "LanguageId", "AbilityId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edu_AbilityLocalizations");

            migrationBuilder.DropTable(
                name: "edu_Abilities");

            migrationBuilder.InsertData(
                table: "edu_QualificationTypes",
                columns: new[] { "Id", "DefaultName" },
                values: new object[] { 6, "Άλλο" });
        }
    }
}
