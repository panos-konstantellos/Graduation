using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "sys_Languages",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 1, "ice" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 27, "civ" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 25, "mech" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 24, "geo" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 23, "idpe" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 22, "bme" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 21, "phaa" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 20, "cons" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 19, "ia" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 18, "gd" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 17, "phys" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 16, "nurs" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 15, "midw" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 26, "na" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 13, "bisc" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 2, "eee" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 3, "pch" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 4, "php" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 14, "ot" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 6, "alis" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 5, "ecec" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 8, "tourism" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 9, "sw" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 10, "accfin" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 11, "fst" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 12, "wvbs" });

            migrationBuilder.InsertData(
                table: "edu_Departments",
                columns: new[] { "Id", "Code" },
                values: new object[] { 7, "ba" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 145, "oj", "Ojibwa" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 140, "ii", "Nuosu" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 149, "or", "Oriya" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 144, "oc", "Occitan (post 1500)" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 150, "om", "Oromo" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 157, "pl", "Polish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 153, "pi", "Pali" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 155, "ps", "Pashto" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 156, "fa", "Persian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 158, "pt", "Portuguese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 159, "pa", "Punjabi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 161, "qu", "Quechua" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 162, "ro", "Romanian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 139, "nn", "Norwegian Nynorsk" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 151, "os", "Ossetian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 138, "nb", "Norwegian Bokmål" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 124, "mh", "Marshallese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 136, "se", "Northern Sami" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 112, "lt", "Lithuanian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 113, "lu", "Luba-Katanga" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 114, "lb", "Luxembourgish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 115, "mk", "Macedonian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 116, "mg", "Malagasy" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 117, "ms", "Malay" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 118, "ml", "Malayalam" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 119, "dv", "Maldivian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 120, "mt", "Maltese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 121, "gv", "Manx" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 122, "mi", "Maori" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 137, "no", "Norwegian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 123, "mr", "Marathi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 127, "mn", "Mongolian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 128, "na", "Nauru" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 130, "nv", "Navajo" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 133, "ng", "Ndonga" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 134, "ne", "Nepali" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 135, "nd", "North Ndebele" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 163, "rm", "Romansh" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 164, "rn", "Rundi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 177, "sk", "Slovak" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 166, "sm", "Samoan" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 195, "ti", "Tigrinya" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 196, "to", "Tonga (Tonga Islands)" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 197, "ts", "Tsonga" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 198, "tn", "Tswana" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 199, "tr", "Turkish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 200, "tk", "Turkmen" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 201, "tw", "Twi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 203, "uk", "Ukrainian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 204, "ur", "Urdu" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 205, "ug", "Uyghur" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 206, "uz", "Uzbek" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 208, "ve", "Venda" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 209, "vi", "Vietnamese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 210, "vo", "Volapük" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 211, "wa", "Walloon" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 212, "cy", "Welsh" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 213, "fy", "Western Frisian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 214, "wo", "Wolof" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 215, "xh", "Xhosa" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 216, "yi", "Yiddish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 217, "yo", "Yoruba" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 194, "bo", "Tibetan" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 193, "th", "Thai" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 192, "te", "Telugu" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 191, "tt", "Tatar" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 167, "sg", "Sango" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 168, "sa", "Sanskrit" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 169, "sc", "Sardinian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 171, "sr", "Serbian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 172, "sn", "Shona" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 174, "sd", "Sindhi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 175, "si", "Sinhala" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 111, "ln", "Lingala" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 165, "ru", "Russian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 178, "sl", "Slovenian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 180, "st", "Sotho, Southern" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 181, "nr", "South Ndebele" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 182, "es", "Spanish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 183, "su", "Sundanese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 184, "sw", "Swahili" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 185, "ss", "Swati" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 186, "sv", "Swedish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 187, "tl", "Tagalog" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 188, "ty", "Tahitian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 189, "tg", "Tajik" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 190, "ta", "Tamil" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 179, "so", "Somali" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 108, "li", "Limburgan" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 29, "ca", "Catalan" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 30, "km", "Central Khmer" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 31, "ch", "Chamorro" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 32, "ce", "Chechen" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 33, "ny", "Chewa" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 35, "zh", "Chinese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 37, "cu", "Church Slavic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 39, "cv", "Chuvash" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 40, "kw", "Cornish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 41, "co", "Corsican" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 42, "cr", "Cree" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 43, "hr", "Croatian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 44, "cs", "Czech" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 45, "da", "Danish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 48, "nl", "Dutch" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 49, "dz", "Dzongkha" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 50, "en", "English" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 51, "eo", "Esperanto" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 27, "my", "Burmese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 26, "bg", "Bulgarian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 25, "br", "Breton" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "el", "Greek" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 2, "ab", "Abkhazian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 3, "aa", "Afar" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 4, "af", "Afrikaans" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 5, "ak", "Akan" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 6, "sq", "Albanian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 7, "am", "Amharic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 8, "ar", "Arabic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 9, "an", "Aragonese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 10, "hy", "Armenian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 11, "as", "Assamese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 52, "et", "Estonian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 12, "av", "Avaric" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 14, "ay", "Aymara" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 15, "az", "Azerbaijani" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 16, "bm", "Bambara" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 17, "ba", "Bashkir" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 18, "eu", "Basque" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 19, "be", "Belarusian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 20, "bn", "Bengali" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 21, "bh", "Bihari languages" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 22, "bi", "Bislama" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 24, "bs", "Bosnian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 13, "ae", "Avestan" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 53, "ee", "Ewe" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 54, "fo", "Faroese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 55, "fj", "Fijian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 84, "ik", "Inupiaq" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 85, "ga", "Irish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 86, "it", "Italian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 87, "ja", "Japanese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 88, "jv", "Javanese" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 90, "kn", "Kannada" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 91, "kr", "Kanuri" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 92, "ks", "Kashmiri" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 93, "kk", "Kazakh" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 94, "ki", "Kikuyu" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 83, "iu", "Inuktitut" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 95, "rw", "Kinyarwanda" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 97, "kv", "Komi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 98, "kg", "Kongo" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 99, "ko", "Korean" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 101, "ku", "Kurdish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 102, "kj", "Kwanyama" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 103, "ky", "Kyrgyz" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 104, "lo", "Lao" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 105, "la", "Latin" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 106, "lv", "Latvian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 218, "za", "Zhuang" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 82, "ie", "Interlingue" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 80, "id", "Indonesian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 56, "fi", "Finnish" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 58, "fr", "French" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 59, "ff", "Fulah" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 60, "gd", "Gaelic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 61, "gl", "Galician" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 62, "lg", "Ganda" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 63, "ka", "Georgian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 64, "de", "German" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 66, "kl", "Greenlandic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 81, "ia", "Interlingua (International Auxiliary Language Association)" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 67, "gn", "Guarani" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 69, "ht", "Haitian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 71, "ha", "Hausa" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 72, "he", "Hebrew" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 73, "hz", "Herero" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 74, "hi", "Hindi" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 75, "ho", "Hiri Motu" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 76, "hu", "Hungarian" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 77, "is", "Icelandic" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 78, "io", "Ido" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 79, "ig", "Igbo" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 68, "gu", "Gujarati" });

            migrationBuilder.InsertData(
                table: "sys_Languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 219, "zu", "Zulu" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 1, 1, 1, "τμήμα μηχανικών πληροφορικής και υπολογιστών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 25, 25, 1, "τμήμα μηχανολόγων μηχανικών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 24, 24, 1, "τμήμα μηχανικών τοπογραφίας και γεωπληροφορικής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 23, 23, 1, "τμήμα μηχανικών βιομηχανικής σχεδίασης και παραγωγής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 22, 22, 1, "τμήμα μηχανικών βιοϊατρικής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 21, 21, 1, "τμήμα φωτογραφίας και οπτικοακουστικών τεχνών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 20, 20, 1, "τμήμα συντήρησης αρχαιοτήτων και έργων τέχνης" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 19, 19, 1, "τμήμα εσωτερικής αρχιτεκτονικής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 18, 18, 1, "τμήμα γραφιστικής και οπτικής επικοινωνίας" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 17, 17, 1, "τμήμα φυσικοθεραπείας" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 16, 16, 1, "τμήμα νοσηλευτικής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 15, 15, 1, "τμήμα μαιευτικής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 26, 26, 1, "τμήμα ναυπηγών μηχανικών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 14, 14, 1, "τμήμα εργοθεραπείας" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 12, 12, 1, "τμήμα επιστημών οίνου, αμπέλου και ποτών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 11, 11, 1, "τμήμα επιστήμης και τεχνολογίας τροφίμων" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 10, 10, 1, "τμήμα λογιστικής και χρηματοοικονομικής" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 9, 9, 1, "τμήμα κοινωνικής εργασίας" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 8, 8, 1, "τμήμα διοίκησης τουρισμού" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 7, 7, 1, "τμήμα διοίκησης επιχειρήσεων" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 6, 6, 1, "τμήμα αρχειονομίας, βιβλιοθηκονομίας και συστημάτων πληροφόρησης" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 5, 5, 1, "τμήμα αγωγής και φροντιδας στην πρώιμη παιδική ηλικία" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 4, 4, 1, "τμήμα πολιτικών δημόσιας υγείας" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 3, 3, 1, "τμήμα δημόσιας και κοινοτικής υγείας" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 2, 2, 1, "τμήμα ηλεκτρολόγων και ηλεκτρονικών μηχανικών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 13, 13, 1, "τμήμα βιοϊατρικών επιστημών" });

            migrationBuilder.InsertData(
                table: "edu_DepartmentLocalizations",
                columns: new[] { "Id", "DepartmentId", "LanguageId", "Name" },
                values: new object[] { 27, 27, 1, "τμήμα πολιτικών μηχανικών" });
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
