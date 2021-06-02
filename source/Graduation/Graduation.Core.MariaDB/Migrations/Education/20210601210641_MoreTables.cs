using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class MoreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_DisabilityAids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisabilityAidType = table.Column<int>(type: "int", nullable: false),
                    DefaultTitle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_DisabilityAids", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_LearningDifficulties",
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
                    table.PrimaryKey("PK_edu_LearningDifficulties", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_OperationalDifficulties",
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
                    table.PrimaryKey("PK_edu_OperationalDifficulties", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_PcInputOutputDevices",
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
                    table.PrimaryKey("PK_edu_PcInputOutputDevices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_DisabilityAidLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    DisabilityAidId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_DisabilityAidLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_DisabilityAidLocalizations_edu_DisabilityAids_Disability~",
                        column: x => x.DisabilityAidId,
                        principalTable: "edu_DisabilityAids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_DisabilityAidLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_LearningDifficultyLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    LearningDifficultyId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_LearningDifficultyLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_LearningDifficultyLocalizations_edu_LearningDifficulties~",
                        column: x => x.LearningDifficultyId,
                        principalTable: "edu_LearningDifficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_LearningDifficultyLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_OperationalDifficultyLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    OperationalDifficultyId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_OperationalDifficultyLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_OperationalDifficultyLocalizations_edu_OperationalDiffic~",
                        column: x => x.OperationalDifficultyId,
                        principalTable: "edu_OperationalDifficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_OperationalDifficultyLocalizations_sys_Languages_Languag~",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_PcInputOutputDeviceLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    PcInputOutputDeviceId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_PcInputOutputDeviceLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_PcInputOutputDeviceLocalizations_edu_PcInputOutputDevice~",
                        column: x => x.PcInputOutputDeviceId,
                        principalTable: "edu_PcInputOutputDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_PcInputOutputDeviceLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[,]
                {
                    { 1, "hearing", null, "ακουστικό βαρηκοΐας", 0 },
                    { 2, "wheelchair", null, "αναπηρικό αμαξίδιο", 0 },
                    { 3, "speechComposer", null, "συνθέτη ομιλίας", 1 },
                    { 4, "virtualKeyboard", null, "εικονικό πληκτρολόγιο", 1 },
                    { 5, "switches", null, "διακόπτες", 1 },
                    { 6, "screenReader", null, "αναγνώστη οθόνης", 1 },
                    { 7, "brailleScreen", null, "οθόνη Braille", 1 }
                });

            migrationBuilder.InsertData(
                table: "edu_LearningDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[,]
                {
                    { 5, "studentQuestions", null, "Διατύπωση αποριών;" },
                    { 4, "studentNotes", null, "Συγγραφή σημειώσεων;" },
                    { 2, "teacherWriting", null, "Τι γράφει στον πίνακα;" },
                    { 1, "teacherSpeech", null, "Τι λέει ο καθηγητής;" },
                    { 3, "teacherScreen", null, "Τι προβάλει στην οθόνη;" }
                });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[,]
                {
                    { 4, "classroom", null, "Αίθουσες Διδασκαλίας" },
                    { 7, "secretary", null, "Γραμματεία" },
                    { 6, "laboratory", null, "Εργαστήρια" },
                    { 5, "amphitheater", null, "Αμφιθέατρα" },
                    { 3, "elevator", null, "Ανελκυστήρες" },
                    { 9, "orientation", null, "Προσανατολισμός στους χώρους του κτιρίου" },
                    { 1, "library", null, "Βιβλιοθήκη" },
                    { 8, "canteen", null, "Κυλικείο" },
                    { 2, "wc", null, "Τουαλέτες" }
                });

            migrationBuilder.InsertData(
                table: "edu_PcInputOutputDevices",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[,]
                {
                    { 4, "speakers", null, "Ηχεία" },
                    { 3, "screen", null, "Οθόνη" },
                    { 2, "mouse", null, "Ποντίκι" },
                    { 1, "keyboard", null, "Πληκτρολόγιο" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_edu_DisabilityAidLocalizations_DisabilityAidId",
                table: "edu_DisabilityAidLocalizations",
                column: "DisabilityAidId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_DisabilityAidLocalizations_LanguageId_DisabilityAidId",
                table: "edu_DisabilityAidLocalizations",
                columns: new[] { "LanguageId", "DisabilityAidId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_LearningDifficultyLocalizations_LanguageId_LearningDiffi~",
                table: "edu_LearningDifficultyLocalizations",
                columns: new[] { "LanguageId", "LearningDifficultyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_LearningDifficultyLocalizations_LearningDifficultyId",
                table: "edu_LearningDifficultyLocalizations",
                column: "LearningDifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_OperationalDifficultyLocalizations_LanguageId_Operationa~",
                table: "edu_OperationalDifficultyLocalizations",
                columns: new[] { "LanguageId", "OperationalDifficultyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_OperationalDifficultyLocalizations_OperationalDifficulty~",
                table: "edu_OperationalDifficultyLocalizations",
                column: "OperationalDifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_PcInputOutputDeviceLocalizations_LanguageId_PcInputOutpu~",
                table: "edu_PcInputOutputDeviceLocalizations",
                columns: new[] { "LanguageId", "PcInputOutputDeviceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_PcInputOutputDeviceLocalizations_PcInputOutputDeviceId",
                table: "edu_PcInputOutputDeviceLocalizations",
                column: "PcInputOutputDeviceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edu_DisabilityAidLocalizations");

            migrationBuilder.DropTable(
                name: "edu_LearningDifficultyLocalizations");

            migrationBuilder.DropTable(
                name: "edu_OperationalDifficultyLocalizations");

            migrationBuilder.DropTable(
                name: "edu_PcInputOutputDeviceLocalizations");

            migrationBuilder.DropTable(
                name: "edu_DisabilityAids");

            migrationBuilder.DropTable(
                name: "edu_LearningDifficulties");

            migrationBuilder.DropTable(
                name: "edu_OperationalDifficulties");

            migrationBuilder.DropTable(
                name: "edu_PcInputOutputDevices");
        }
    }
}
