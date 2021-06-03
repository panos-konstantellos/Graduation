using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class MoreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edu_DisabilityAids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    DisabilityAidType = table.Column<int>(type: "INTEGER", nullable: false),
                    DefaultTitle = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_DisabilityAids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_LearningDifficulties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultTitle = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_LearningDifficulties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_OperationalDifficulties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultTitle = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_OperationalDifficulties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_PcInputOutputDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultTitle = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_PcInputOutputDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_DisabilityAidLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisabilityAidId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_DisabilityAidLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_DisabilityAidLocalizations_edu_DisabilityAids_DisabilityAidId",
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
                });

            migrationBuilder.CreateTable(
                name: "edu_LearningDifficultyLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    LearningDifficultyId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_LearningDifficultyLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_LearningDifficultyLocalizations_edu_LearningDifficulties_LearningDifficultyId",
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
                });

            migrationBuilder.CreateTable(
                name: "edu_OperationalDifficultyLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    OperationalDifficultyId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_OperationalDifficultyLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_OperationalDifficultyLocalizations_edu_OperationalDifficulties_OperationalDifficultyId",
                        column: x => x.OperationalDifficultyId,
                        principalTable: "edu_OperationalDifficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_edu_OperationalDifficultyLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "edu_PcInputOutputDeviceLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    PcInputOutputDeviceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_PcInputOutputDeviceLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_PcInputOutputDeviceLocalizations_edu_PcInputOutputDevices_PcInputOutputDeviceId",
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
                });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 1, "hearing", null, "ακουστικό βαρηκοΐας", 0 });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 2, "wheelchair", null, "αναπηρικό αμαξίδιο", 0 });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 3, "speechComposer", null, "συνθέτη ομιλίας", 1 });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 4, "virtualKeyboard", null, "εικονικό πληκτρολόγιο", 1 });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 5, "switches", null, "διακόπτες", 1 });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 6, "screenReader", null, "αναγνώστη οθόνης", 1 });

            migrationBuilder.InsertData(
                table: "edu_DisabilityAids",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle", "DisabilityAidType" },
                values: new object[] { 7, "brailleScreen", null, "οθόνη Braille", 1 });

            migrationBuilder.InsertData(
                table: "edu_LearningDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 5, "studentQuestions", null, "Διατύπωση αποριών;" });

            migrationBuilder.InsertData(
                table: "edu_LearningDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 4, "studentNotes", null, "Συγγραφή σημειώσεων;" });

            migrationBuilder.InsertData(
                table: "edu_LearningDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 2, "teacherWriting", null, "Τι γράφει στον πίνακα;" });

            migrationBuilder.InsertData(
                table: "edu_LearningDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 1, "teacherSpeech", null, "Τι λέει ο καθηγητής;" });

            migrationBuilder.InsertData(
                table: "edu_LearningDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 3, "teacherScreen", null, "Τι προβάλει στην οθόνη;" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 4, "classroom", null, "Αίθουσες Διδασκαλίας" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 7, "secretary", null, "Γραμματεία" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 6, "laboratory", null, "Εργαστήρια" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 5, "amphitheater", null, "Αμφιθέατρα" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 3, "elevator", null, "Ανελκυστήρες" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 9, "orientation", null, "Προσανατολισμός στους χώρους του κτιρίου" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 1, "library", null, "Βιβλιοθήκη" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 8, "canteen", null, "Κυλικείο" });

            migrationBuilder.InsertData(
                table: "edu_OperationalDifficulties",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 2, "wc", null, "Τουαλέτες" });

            migrationBuilder.InsertData(
                table: "edu_PcInputOutputDevices",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 4, "speakers", null, "Ηχεία" });

            migrationBuilder.InsertData(
                table: "edu_PcInputOutputDevices",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 3, "screen", null, "Οθόνη" });

            migrationBuilder.InsertData(
                table: "edu_PcInputOutputDevices",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 2, "mouse", null, "Ποντίκι" });

            migrationBuilder.InsertData(
                table: "edu_PcInputOutputDevices",
                columns: new[] { "Id", "Code", "DefaultDescription", "DefaultTitle" },
                values: new object[] { 1, "keyboard", null, "Πληκτρολόγιο" });

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
                name: "IX_edu_LearningDifficultyLocalizations_LanguageId_LearningDifficultyId",
                table: "edu_LearningDifficultyLocalizations",
                columns: new[] { "LanguageId", "LearningDifficultyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_LearningDifficultyLocalizations_LearningDifficultyId",
                table: "edu_LearningDifficultyLocalizations",
                column: "LearningDifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_OperationalDifficultyLocalizations_LanguageId_OperationalDifficultyId",
                table: "edu_OperationalDifficultyLocalizations",
                columns: new[] { "LanguageId", "OperationalDifficultyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_edu_OperationalDifficultyLocalizations_OperationalDifficultyId",
                table: "edu_OperationalDifficultyLocalizations",
                column: "OperationalDifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_PcInputOutputDeviceLocalizations_LanguageId_PcInputOutputDeviceId",
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
