using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "sys_Languages",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "ice" },
                    { 27, "civ" },
                    { 25, "mech" },
                    { 24, "geo" },
                    { 23, "idpe" },
                    { 22, "bme" },
                    { 21, "phaa" },
                    { 20, "cons" },
                    { 19, "ia" },
                    { 18, "gd" },
                    { 17, "phys" },
                    { 16, "nurs" },
                    { 15, "midw" },
                    { 26, "na" },
                    { 13, "bisc" },
                    { 2, "eee" },
                    { 3, "pch" },
                    { 4, "php" },
                    { 14, "ot" },
                    { 6, "alis" },
                    { 5, "ecec" },
                    { 8, "tourism" },
                    { 9, "sw" },
                    { 10, "accfin" },
                    { 11, "fst" },
                    { 12, "wvbs" },
                    { 7, "ba" }
                });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 145, "oj", "Ojibwa" },
                    { 140, "ii", "Nuosu" },
                    { 149, "or", "Oriya" },
                    { 144, "oc", "Occitan (post 1500)" },
                    { 150, "om", "Oromo" },
                    { 157, "pl", "Polish" },
                    { 153, "pi", "Pali" },
                    { 155, "ps", "Pashto" },
                    { 156, "fa", "Persian" },
                    { 158, "pt", "Portuguese" },
                    { 159, "pa", "Punjabi" },
                    { 161, "qu", "Quechua" },
                    { 162, "ro", "Romanian" },
                    { 139, "nn", "Norwegian Nynorsk" },
                    { 151, "os", "Ossetian" },
                    { 138, "nb", "Norwegian Bokmål" },
                    { 124, "mh", "Marshallese" },
                    { 136, "se", "Northern Sami" },
                    { 112, "lt", "Lithuanian" },
                    { 113, "lu", "Luba-Katanga" },
                    { 114, "lb", "Luxembourgish" },
                    { 115, "mk", "Macedonian" },
                    { 116, "mg", "Malagasy" },
                    { 117, "ms", "Malay" },
                    { 118, "ml", "Malayalam" },
                    { 119, "dv", "Maldivian" },
                    { 120, "mt", "Maltese" },
                    { 121, "gv", "Manx" },
                    { 122, "mi", "Maori" },
                    { 137, "no", "Norwegian" },
                    { 123, "mr", "Marathi" },
                    { 127, "mn", "Mongolian" },
                    { 128, "na", "Nauru" },
                    { 130, "nv", "Navajo" },
                    { 133, "ng", "Ndonga" },
                    { 134, "ne", "Nepali" },
                    { 135, "nd", "North Ndebele" },
                    { 163, "rm", "Romansh" },
                    { 164, "rn", "Rundi" },
                    { 177, "sk", "Slovak" },
                    { 166, "sm", "Samoan" },
                    { 195, "ti", "Tigrinya" },
                    { 196, "to", "Tonga (Tonga Islands)" },
                    { 197, "ts", "Tsonga" },
                    { 198, "tn", "Tswana" },
                    { 199, "tr", "Turkish" },
                    { 200, "tk", "Turkmen" },
                    { 201, "tw", "Twi" },
                    { 203, "uk", "Ukrainian" },
                    { 204, "ur", "Urdu" },
                    { 205, "ug", "Uyghur" },
                    { 206, "uz", "Uzbek" },
                    { 208, "ve", "Venda" },
                    { 209, "vi", "Vietnamese" },
                    { 210, "vo", "Volapük" },
                    { 211, "wa", "Walloon" },
                    { 212, "cy", "Welsh" },
                    { 213, "fy", "Western Frisian" },
                    { 214, "wo", "Wolof" },
                    { 215, "xh", "Xhosa" },
                    { 216, "yi", "Yiddish" },
                    { 217, "yo", "Yoruba" },
                    { 194, "bo", "Tibetan" },
                    { 193, "th", "Thai" },
                    { 192, "te", "Telugu" },
                    { 191, "tt", "Tatar" },
                    { 167, "sg", "Sango" },
                    { 168, "sa", "Sanskrit" },
                    { 169, "sc", "Sardinian" },
                    { 171, "sr", "Serbian" },
                    { 172, "sn", "Shona" },
                    { 174, "sd", "Sindhi" },
                    { 175, "si", "Sinhala" },
                    { 111, "ln", "Lingala" },
                    { 165, "ru", "Russian" },
                    { 178, "sl", "Slovenian" },
                    { 180, "st", "Sotho, Southern" },
                    { 181, "nr", "South Ndebele" },
                    { 182, "es", "Spanish" },
                    { 183, "su", "Sundanese" },
                    { 184, "sw", "Swahili" },
                    { 185, "ss", "Swati" },
                    { 186, "sv", "Swedish" },
                    { 187, "tl", "Tagalog" },
                    { 188, "ty", "Tahitian" },
                    { 189, "tg", "Tajik" },
                    { 190, "ta", "Tamil" },
                    { 179, "so", "Somali" },
                    { 108, "li", "Limburgan" },
                    { 29, "ca", "Catalan" },
                    { 30, "km", "Central Khmer" },
                    { 31, "ch", "Chamorro" },
                    { 32, "ce", "Chechen" },
                    { 33, "ny", "Chewa" },
                    { 35, "zh", "Chinese" },
                    { 37, "cu", "Church Slavic" },
                    { 39, "cv", "Chuvash" },
                    { 40, "kw", "Cornish" },
                    { 41, "co", "Corsican" },
                    { 42, "cr", "Cree" },
                    { 43, "hr", "Croatian" },
                    { 44, "cs", "Czech" },
                    { 45, "da", "Danish" },
                    { 48, "nl", "Dutch" },
                    { 49, "dz", "Dzongkha" },
                    { 50, "en", "English" },
                    { 51, "eo", "Esperanto" },
                    { 27, "my", "Burmese" },
                    { 26, "bg", "Bulgarian" },
                    { 25, "br", "Breton" },
                    { 1, "el", "Greek" },
                    { 2, "ab", "Abkhazian" },
                    { 3, "aa", "Afar" },
                    { 4, "af", "Afrikaans" },
                    { 5, "ak", "Akan" },
                    { 6, "sq", "Albanian" },
                    { 7, "am", "Amharic" },
                    { 8, "ar", "Arabic" },
                    { 9, "an", "Aragonese" },
                    { 10, "hy", "Armenian" },
                    { 11, "as", "Assamese" },
                    { 52, "et", "Estonian" },
                    { 12, "av", "Avaric" },
                    { 14, "ay", "Aymara" },
                    { 15, "az", "Azerbaijani" },
                    { 16, "bm", "Bambara" },
                    { 17, "ba", "Bashkir" },
                    { 18, "eu", "Basque" },
                    { 19, "be", "Belarusian" },
                    { 20, "bn", "Bengali" },
                    { 21, "bh", "Bihari languages" },
                    { 22, "bi", "Bislama" },
                    { 24, "bs", "Bosnian" },
                    { 13, "ae", "Avestan" },
                    { 53, "ee", "Ewe" },
                    { 54, "fo", "Faroese" },
                    { 55, "fj", "Fijian" },
                    { 84, "ik", "Inupiaq" },
                    { 85, "ga", "Irish" },
                    { 86, "it", "Italian" },
                    { 87, "ja", "Japanese" },
                    { 88, "jv", "Javanese" },
                    { 90, "kn", "Kannada" },
                    { 91, "kr", "Kanuri" },
                    { 92, "ks", "Kashmiri" },
                    { 93, "kk", "Kazakh" },
                    { 94, "ki", "Kikuyu" },
                    { 83, "iu", "Inuktitut" },
                    { 95, "rw", "Kinyarwanda" },
                    { 97, "kv", "Komi" },
                    { 98, "kg", "Kongo" },
                    { 99, "ko", "Korean" },
                    { 101, "ku", "Kurdish" },
                    { 102, "kj", "Kwanyama" },
                    { 103, "ky", "Kyrgyz" },
                    { 104, "lo", "Lao" },
                    { 105, "la", "Latin" },
                    { 106, "lv", "Latvian" },
                    { 218, "za", "Zhuang" },
                    { 82, "ie", "Interlingue" },
                    { 80, "id", "Indonesian" },
                    { 56, "fi", "Finnish" },
                    { 58, "fr", "French" },
                    { 59, "ff", "Fulah" },
                    { 60, "gd", "Gaelic" },
                    { 61, "gl", "Galician" },
                    { 62, "lg", "Ganda" },
                    { 63, "ka", "Georgian" },
                    { 64, "de", "German" },
                    { 66, "kl", "Greenlandic" },
                    { 81, "ia", "Interlingua (International Auxiliary Language Association)" },
                    { 67, "gn", "Guarani" },
                    { 69, "ht", "Haitian" },
                    { 71, "ha", "Hausa" },
                    { 72, "he", "Hebrew" },
                    { 73, "hz", "Herero" },
                    { 74, "hi", "Hindi" },
                    { 75, "ho", "Hiri Motu" },
                    { 76, "hu", "Hungarian" },
                    { 77, "is", "Icelandic" },
                    { 78, "io", "Ido" },
                    { 79, "ig", "Igbo" },
                    { 68, "gu", "Gujarati" },
                    { 219, "zu", "Zulu" }
                });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "τμήμα μηχανικών πληροφορικής και υπολογιστών" },
                    { 25, 25, 1, "τμήμα μηχανολόγων μηχανικών" },
                    { 24, 24, 1, "τμήμα μηχανικών τοπογραφίας και γεωπληροφορικής" },
                    { 23, 23, 1, "τμήμα μηχανικών βιομηχανικής σχεδίασης και παραγωγής" },
                    { 22, 22, 1, "τμήμα μηχανικών βιοϊατρικής" },
                    { 21, 21, 1, "τμήμα φωτογραφίας και οπτικοακουστικών τεχνών" },
                    { 20, 20, 1, "τμήμα συντήρησης αρχαιοτήτων και έργων τέχνης" },
                    { 19, 19, 1, "τμήμα εσωτερικής αρχιτεκτονικής" },
                    { 18, 18, 1, "τμήμα γραφιστικής και οπτικής επικοινωνίας" },
                    { 17, 17, 1, "τμήμα φυσικοθεραπείας" },
                    { 16, 16, 1, "τμήμα νοσηλευτικής" },
                    { 15, 15, 1, "τμήμα μαιευτικής" },
                    { 26, 26, 1, "τμήμα ναυπηγών μηχανικών" },
                    { 14, 14, 1, "τμήμα εργοθεραπείας" },
                    { 12, 12, 1, "τμήμα επιστημών οίνου, αμπέλου και ποτών" },
                    { 11, 11, 1, "τμήμα επιστήμης και τεχνολογίας τροφίμων" },
                    { 10, 10, 1, "τμήμα λογιστικής και χρηματοοικονομικής" },
                    { 9, 9, 1, "τμήμα κοινωνικής εργασίας" },
                    { 8, 8, 1, "τμήμα διοίκησης τουρισμού" },
                    { 7, 7, 1, "τμήμα διοίκησης επιχειρήσεων" },
                    { 6, 6, 1, "τμήμα αρχειονομίας, βιβλιοθηκονομίας και συστημάτων πληροφόρησης" },
                    { 5, 5, 1, "τμήμα αγωγής και φροντιδας στην πρώιμη παιδική ηλικία" },
                    { 4, 4, 1, "τμήμα πολιτικών δημόσιας υγείας" },
                    { 3, 3, 1, "τμήμα δημόσιας και κοινοτικής υγείας" },
                    { 2, 2, 1, "τμήμα ηλεκτρολόγων και ηλεκτρονικών μηχανικών" },
                    { 13, 13, 1, "τμήμα βιοϊατρικών επιστημών" },
                    { 27, 27, 1, "τμήμα πολιτικών μηχανικών" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "edu_DepartmentLocalizations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 145);

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

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "edu_Departments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "sys_Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "sys_Languages");
        }
    }
}
