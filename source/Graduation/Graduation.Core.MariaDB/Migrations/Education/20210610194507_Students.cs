using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.MariaDB.Migrations.Education
{
    public partial class Students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefaultName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_Countries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mobile = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prefecture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_edu_Students_sys_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "sys_Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_CountryLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_CountryLocalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sys_CountryLocalizations_sys_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "sys_Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_CountryLocalizations_sys_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "sys_Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[,]
                {
                    { 1, "AF", "Afghanistan" },
                    { 158, "NC", "New Caledonia" },
                    { 159, "NZ", "New Zealand" },
                    { 160, "NI", "Nicaragua" },
                    { 161, "NE", "Niger" },
                    { 162, "NG", "Nigeria" },
                    { 163, "NU", "Niue" },
                    { 164, "NF", "Norfolk Island" },
                    { 165, "MP", "Northern Mariana Islands" },
                    { 166, "NO", "Norway" },
                    { 167, "OM", "Oman" },
                    { 168, "PK", "Pakistan" },
                    { 169, "PW", "Palau" },
                    { 170, "PS", "Palestine, State of" },
                    { 171, "PA", "Panama" },
                    { 172, "PG", "Papua New Guinea" },
                    { 173, "PY", "Paraguay" },
                    { 174, "PE", "Peru" },
                    { 175, "PH", "Philippines" },
                    { 176, "PN", "Pitcairn" },
                    { 177, "PL", "Poland" },
                    { 178, "PT", "Portugal" },
                    { 179, "PR", "Puerto Rico" },
                    { 180, "QA", "Qatar" },
                    { 181, "RE", "Réunion" },
                    { 182, "RO", "Romania" },
                    { 183, "RU", "Russian Federation" },
                    { 184, "RW", "Rwanda" },
                    { 157, "NL", "Netherlands" },
                    { 185, "BL", "Saint Barthélemy" },
                    { 156, "NP", "Nepal" },
                    { 154, "NA", "Namibia" },
                    { 127, "LY", "Libya" },
                    { 128, "LI", "Liechtenstein" },
                    { 129, "LT", "Lithuania" },
                    { 130, "LU", "Luxembourg" },
                    { 131, "MO", "Macao" },
                    { 132, "MK", "Macedonia, the Former Yugoslav Republic of" },
                    { 133, "MG", "Madagascar" },
                    { 134, "MW", "Malawi" },
                    { 135, "MY", "Malaysia" },
                    { 136, "MV", "Maldives" },
                    { 137, "ML", "Mali" },
                    { 138, "MT", "Malta" },
                    { 139, "MH", "Marshall Islands" },
                    { 140, "MQ", "Martinique" },
                    { 141, "MR", "Mauritania" },
                    { 142, "MU", "Mauritius" },
                    { 143, "YT", "Mayotte" },
                    { 144, "MX", "Mexico" },
                    { 145, "FM", "Micronesia, Federated States of" },
                    { 146, "MD", "Moldova, Republic of" },
                    { 147, "MC", "Monaco" },
                    { 148, "MN", "Mongolia" },
                    { 149, "ME", "Montenegro" },
                    { 150, "MS", "Montserrat" },
                    { 151, "MA", "Morocco" },
                    { 152, "MZ", "Mozambique" },
                    { 153, "MM", "Myanmar" },
                    { 155, "NR", "Nauru" },
                    { 186, "SH", "Saint Helena, Ascension and Tristan da Cunha" },
                    { 187, "KN", "Saint Kitts and Nevis" },
                    { 188, "LC", "Saint Lucia" },
                    { 221, "TH", "Thailand" },
                    { 222, "TL", "Timor-Leste" },
                    { 223, "TG", "Togo" },
                    { 224, "TK", "Tokelau" },
                    { 225, "TO", "Tonga" },
                    { 226, "TT", "Trinidad and Tobago" },
                    { 227, "TN", "Tunisia" },
                    { 228, "TR", "Turkey" },
                    { 229, "TM", "Turkmenistan" },
                    { 230, "TC", "Turks and Caicos Islands" },
                    { 231, "TV", "Tuvalu" },
                    { 232, "UG", "Uganda" },
                    { 233, "UA", "Ukraine" },
                    { 234, "AE", "United Arab Emirates" },
                    { 235, "GB", "United Kingdom" },
                    { 236, "US", "United States" },
                    { 237, "UM", "United States Minor Outlying Islands" },
                    { 238, "UY", "Uruguay" },
                    { 239, "UZ", "Uzbekistan" },
                    { 240, "VU", "Vanuatu" },
                    { 241, "VE", "Venezuela, Bolivarian Republic of" },
                    { 242, "VN", "Viet Nam" },
                    { 243, "VG", "Virgin Islands, British" },
                    { 244, "VI", "Virgin Islands, U.S." },
                    { 245, "WF", "Wallis and Futuna" },
                    { 246, "EH", "Western Sahara" },
                    { 247, "YE", "Yemen" },
                    { 220, "TZ", "Tanzania, United Republic of" },
                    { 219, "TJ", "Tajikistan" },
                    { 218, "TW", "Taiwan, Province of China" },
                    { 217, "SY", "Syrian Arab Republic" },
                    { 189, "MF", "Saint Martin (French part)" },
                    { 190, "PM", "Saint Pierre and Miquelon" },
                    { 191, "VC", "Saint Vincent and the Grenadines" },
                    { 192, "WS", "Samoa" },
                    { 193, "SM", "San Marino" },
                    { 194, "ST", "Sao Tome and Principe" },
                    { 195, "SA", "Saudi Arabia" },
                    { 196, "SN", "Senegal" },
                    { 197, "RS", "Serbia" },
                    { 198, "SC", "Seychelles" },
                    { 199, "SL", "Sierra Leone" },
                    { 200, "SG", "Singapore" },
                    { 201, "SX", "Sint Maarten (Dutch part)" },
                    { 126, "LR", "Liberia" },
                    { 202, "SK", "Slovakia" },
                    { 204, "SB", "Solomon Islands" },
                    { 205, "SO", "Somalia" },
                    { 206, "ZA", "South Africa" },
                    { 207, "GS", "South Georgia and the South Sandwich Islands" },
                    { 208, "SS", "South Sudan" },
                    { 209, "ES", "Spain" },
                    { 210, "LK", "Sri Lanka" },
                    { 211, "SD", "Sudan" },
                    { 212, "SR", "Suriname" },
                    { 213, "SJ", "Svalbard and Jan Mayen" },
                    { 214, "SZ", "Swaziland" },
                    { 215, "SE", "Sweden" },
                    { 216, "CH", "Switzerland" },
                    { 203, "SI", "Slovenia" },
                    { 248, "ZM", "Zambia" },
                    { 125, "LS", "Lesotho" },
                    { 123, "LV", "Latvia" },
                    { 33, "IO", "British Indian Ocean Territory" },
                    { 34, "BN", "Brunei Darussalam" },
                    { 35, "BG", "Bulgaria" },
                    { 36, "BF", "Burkina Faso" },
                    { 37, "BI", "Burundi" },
                    { 38, "KH", "Cambodia" },
                    { 39, "CM", "Cameroon" },
                    { 40, "CA", "Canada" },
                    { 41, "CV", "Cape Verde" },
                    { 42, "KY", "Cayman Islands" },
                    { 43, "CF", "Central African Republic" },
                    { 44, "TD", "Chad" },
                    { 45, "CL", "Chile" },
                    { 46, "CN", "China" },
                    { 47, "CX", "Christmas Island" },
                    { 48, "CC", "Cocos (Keeling) Islands" },
                    { 49, "CO", "Colombia" },
                    { 50, "KM", "Comoros" },
                    { 51, "CG", "Congo" },
                    { 52, "CD", "Congo, the Democratic Republic of the" },
                    { 53, "CK", "Cook Islands" },
                    { 54, "CR", "Costa Rica" },
                    { 55, "CI", "Côte d'Ivoire" },
                    { 56, "HR", "Croatia" },
                    { 57, "CU", "Cuba" },
                    { 58, "CW", "Curaçao" },
                    { 59, "CY", "Cyprus" },
                    { 32, "BR", "Brazil" },
                    { 60, "CZ", "Czech Republic" },
                    { 31, "BV", "Bouvet Island" },
                    { 29, "BA", "Bosnia and Herzegovina" },
                    { 2, "AX", "Åland Islands" },
                    { 3, "AL", "Albania" },
                    { 4, "DZ", "Algeria" },
                    { 5, "AS", "American Samoa" },
                    { 6, "AD", "Andorra" },
                    { 7, "AO", "Angola" },
                    { 8, "AI", "Anguilla" },
                    { 9, "AQ", "Antarctica" },
                    { 10, "AG", "Antigua and Barbuda" },
                    { 11, "AR", "Argentina" },
                    { 12, "AM", "Armenia" },
                    { 13, "AW", "Aruba" },
                    { 14, "AU", "Australia" },
                    { 15, "AT", "Austria" },
                    { 16, "AZ", "Azerbaijan" },
                    { 17, "BS", "Bahamas" },
                    { 18, "BH", "Bahrain" },
                    { 19, "BD", "Bangladesh" },
                    { 20, "BB", "Barbados" },
                    { 21, "BY", "Belarus" },
                    { 22, "BE", "Belgium" },
                    { 23, "BZ", "Belize" },
                    { 24, "BJ", "Benin" },
                    { 25, "BM", "Bermuda" },
                    { 26, "BT", "Bhutan" },
                    { 27, "BO", "Bolivia, Plurinational State of" },
                    { 28, "BQ", "Bonaire, Sint Eustatius and Saba" },
                    { 30, "BW", "Botswana" },
                    { 61, "DK", "Denmark" },
                    { 62, "DJ", "Djibouti" },
                    { 63, "DM", "Dominica" },
                    { 96, "HT", "Haiti" },
                    { 97, "HM", "Heard Island and McDonald Islands" },
                    { 98, "VA", "Holy See (Vatican City State)" },
                    { 99, "HN", "Honduras" },
                    { 100, "HK", "Hong Kong" },
                    { 101, "HU", "Hungary" },
                    { 102, "IS", "Iceland" },
                    { 103, "IN", "India" },
                    { 104, "ID", "Indonesia" },
                    { 105, "IR", "Iran, Islamic Republic of" },
                    { 106, "IQ", "Iraq" },
                    { 107, "IE", "Ireland" },
                    { 108, "IM", "Isle of Man" },
                    { 109, "IL", "Israel" },
                    { 110, "IT", "Italy" },
                    { 111, "JM", "Jamaica" },
                    { 112, "JP", "Japan" },
                    { 113, "JE", "Jersey" },
                    { 114, "JO", "Jordan" },
                    { 115, "KZ", "Kazakhstan" },
                    { 116, "KE", "Kenya" },
                    { 117, "KI", "Kiribati" },
                    { 118, "KP", "Korea, Democratic People's Republic of" },
                    { 119, "KR", "Korea, Republic of" },
                    { 120, "KW", "Kuwait" },
                    { 121, "KG", "Kyrgyzstan" },
                    { 122, "LA", "Lao People's Democratic Republic" },
                    { 95, "GY", "Guyana" },
                    { 94, "GW", "Guinea-Bissau" },
                    { 93, "GN", "Guinea" },
                    { 92, "GG", "Guernsey" },
                    { 64, "DO", "Dominican Republic" },
                    { 65, "EC", "Ecuador" },
                    { 66, "EG", "Egypt" },
                    { 67, "SV", "El Salvador" },
                    { 68, "GQ", "Equatorial Guinea" },
                    { 69, "ER", "Eritrea" },
                    { 70, "EE", "Estonia" },
                    { 71, "ET", "Ethiopia" },
                    { 72, "FK", "Falkland Islands (Malvinas)" },
                    { 73, "FO", "Faroe Islands" },
                    { 74, "FJ", "Fiji" },
                    { 75, "FI", "Finland" },
                    { 76, "FR", "France" },
                    { 124, "LB", "Lebanon" },
                    { 77, "GF", "French Guiana" },
                    { 79, "TF", "French Southern Territories" },
                    { 80, "GA", "Gabon" },
                    { 81, "GM", "Gambia" },
                    { 82, "GE", "Georgia" },
                    { 83, "DE", "Germany" },
                    { 84, "GH", "Ghana" },
                    { 85, "GI", "Gibraltar" },
                    { 86, "GR", "Greece" },
                    { 87, "GL", "Greenland" },
                    { 88, "GD", "Grenada" },
                    { 89, "GP", "Guadeloupe" },
                    { 90, "GU", "Guam" },
                    { 91, "GT", "Guatemala" },
                    { 78, "PF", "French Polynesia" },
                    { 249, "ZW", "Zimbabwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_edu_Students_CountryId",
                table: "edu_Students",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_edu_Students_RegistrationId",
                table: "edu_Students",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sys_CountryLocalizations_CountryId",
                table: "sys_CountryLocalizations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_CountryLocalizations_LanguageId_CountryId",
                table: "sys_CountryLocalizations",
                columns: new[] { "LanguageId", "CountryId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edu_Students");

            migrationBuilder.DropTable(
                name: "sys_CountryLocalizations");

            migrationBuilder.DropTable(
                name: "sys_Countries");
        }
    }
}
