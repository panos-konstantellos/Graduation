using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation.Core.Sqlite.Migrations.Education
{
    public partial class Students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DefaultName = table.Column<string>(type: "TEXT", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "edu_Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    RegistrationId = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Mobile = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Prefecture = table.Column<string>(type: "TEXT", nullable: true),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "sys_CountryLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 1, "AF", "Afghanistan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 158, "NC", "New Caledonia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 159, "NZ", "New Zealand" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 160, "NI", "Nicaragua" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 161, "NE", "Niger" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 162, "NG", "Nigeria" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 163, "NU", "Niue" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 164, "NF", "Norfolk Island" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 165, "MP", "Northern Mariana Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 166, "NO", "Norway" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 167, "OM", "Oman" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 168, "PK", "Pakistan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 169, "PW", "Palau" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 170, "PS", "Palestine, State of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 171, "PA", "Panama" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 172, "PG", "Papua New Guinea" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 173, "PY", "Paraguay" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 174, "PE", "Peru" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 175, "PH", "Philippines" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 176, "PN", "Pitcairn" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 177, "PL", "Poland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 178, "PT", "Portugal" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 179, "PR", "Puerto Rico" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 180, "QA", "Qatar" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 181, "RE", "Réunion" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 182, "RO", "Romania" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 183, "RU", "Russian Federation" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 184, "RW", "Rwanda" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 157, "NL", "Netherlands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 185, "BL", "Saint Barthélemy" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 156, "NP", "Nepal" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 154, "NA", "Namibia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 127, "LY", "Libya" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 128, "LI", "Liechtenstein" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 129, "LT", "Lithuania" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 130, "LU", "Luxembourg" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 131, "MO", "Macao" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 132, "MK", "Macedonia, the Former Yugoslav Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 133, "MG", "Madagascar" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 134, "MW", "Malawi" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 135, "MY", "Malaysia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 136, "MV", "Maldives" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 137, "ML", "Mali" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 138, "MT", "Malta" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 139, "MH", "Marshall Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 140, "MQ", "Martinique" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 141, "MR", "Mauritania" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 142, "MU", "Mauritius" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 143, "YT", "Mayotte" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 144, "MX", "Mexico" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 145, "FM", "Micronesia, Federated States of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 146, "MD", "Moldova, Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 147, "MC", "Monaco" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 148, "MN", "Mongolia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 149, "ME", "Montenegro" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 150, "MS", "Montserrat" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 151, "MA", "Morocco" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 152, "MZ", "Mozambique" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 153, "MM", "Myanmar" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 155, "NR", "Nauru" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 186, "SH", "Saint Helena, Ascension and Tristan da Cunha" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 187, "KN", "Saint Kitts and Nevis" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 188, "LC", "Saint Lucia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 221, "TH", "Thailand" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 222, "TL", "Timor-Leste" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 223, "TG", "Togo" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 224, "TK", "Tokelau" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 225, "TO", "Tonga" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 226, "TT", "Trinidad and Tobago" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 227, "TN", "Tunisia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 228, "TR", "Turkey" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 229, "TM", "Turkmenistan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 230, "TC", "Turks and Caicos Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 231, "TV", "Tuvalu" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 232, "UG", "Uganda" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 233, "UA", "Ukraine" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 234, "AE", "United Arab Emirates" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 235, "GB", "United Kingdom" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 236, "US", "United States" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 237, "UM", "United States Minor Outlying Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 238, "UY", "Uruguay" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 239, "UZ", "Uzbekistan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 240, "VU", "Vanuatu" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 241, "VE", "Venezuela, Bolivarian Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 242, "VN", "Viet Nam" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 243, "VG", "Virgin Islands, British" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 244, "VI", "Virgin Islands, U.S." });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 245, "WF", "Wallis and Futuna" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 246, "EH", "Western Sahara" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 247, "YE", "Yemen" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 220, "TZ", "Tanzania, United Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 219, "TJ", "Tajikistan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 218, "TW", "Taiwan, Province of China" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 217, "SY", "Syrian Arab Republic" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 189, "MF", "Saint Martin (French part)" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 190, "PM", "Saint Pierre and Miquelon" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 191, "VC", "Saint Vincent and the Grenadines" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 192, "WS", "Samoa" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 193, "SM", "San Marino" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 194, "ST", "Sao Tome and Principe" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 195, "SA", "Saudi Arabia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 196, "SN", "Senegal" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 197, "RS", "Serbia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 198, "SC", "Seychelles" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 199, "SL", "Sierra Leone" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 200, "SG", "Singapore" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 201, "SX", "Sint Maarten (Dutch part)" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 126, "LR", "Liberia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 202, "SK", "Slovakia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 204, "SB", "Solomon Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 205, "SO", "Somalia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 206, "ZA", "South Africa" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 207, "GS", "South Georgia and the South Sandwich Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 208, "SS", "South Sudan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 209, "ES", "Spain" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 210, "LK", "Sri Lanka" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 211, "SD", "Sudan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 212, "SR", "Suriname" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 213, "SJ", "Svalbard and Jan Mayen" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 214, "SZ", "Swaziland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 215, "SE", "Sweden" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 216, "CH", "Switzerland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 203, "SI", "Slovenia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 248, "ZM", "Zambia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 125, "LS", "Lesotho" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 123, "LV", "Latvia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 33, "IO", "British Indian Ocean Territory" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 34, "BN", "Brunei Darussalam" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 35, "BG", "Bulgaria" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 36, "BF", "Burkina Faso" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 37, "BI", "Burundi" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 38, "KH", "Cambodia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 39, "CM", "Cameroon" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 40, "CA", "Canada" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 41, "CV", "Cape Verde" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 42, "KY", "Cayman Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 43, "CF", "Central African Republic" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 44, "TD", "Chad" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 45, "CL", "Chile" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 46, "CN", "China" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 47, "CX", "Christmas Island" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 48, "CC", "Cocos (Keeling) Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 49, "CO", "Colombia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 50, "KM", "Comoros" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 51, "CG", "Congo" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 52, "CD", "Congo, the Democratic Republic of the" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 53, "CK", "Cook Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 54, "CR", "Costa Rica" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 55, "CI", "Côte d'Ivoire" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 56, "HR", "Croatia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 57, "CU", "Cuba" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 58, "CW", "Curaçao" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 59, "CY", "Cyprus" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 32, "BR", "Brazil" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 60, "CZ", "Czech Republic" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 31, "BV", "Bouvet Island" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 29, "BA", "Bosnia and Herzegovina" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 2, "AX", "Åland Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 3, "AL", "Albania" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 4, "DZ", "Algeria" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 5, "AS", "American Samoa" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 6, "AD", "Andorra" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 7, "AO", "Angola" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 8, "AI", "Anguilla" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 9, "AQ", "Antarctica" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 10, "AG", "Antigua and Barbuda" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 11, "AR", "Argentina" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 12, "AM", "Armenia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 13, "AW", "Aruba" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 14, "AU", "Australia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 15, "AT", "Austria" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 16, "AZ", "Azerbaijan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 17, "BS", "Bahamas" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 18, "BH", "Bahrain" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 19, "BD", "Bangladesh" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 20, "BB", "Barbados" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 21, "BY", "Belarus" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 22, "BE", "Belgium" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 23, "BZ", "Belize" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 24, "BJ", "Benin" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 25, "BM", "Bermuda" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 26, "BT", "Bhutan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 27, "BO", "Bolivia, Plurinational State of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 28, "BQ", "Bonaire, Sint Eustatius and Saba" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 30, "BW", "Botswana" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 61, "DK", "Denmark" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 62, "DJ", "Djibouti" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 63, "DM", "Dominica" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 96, "HT", "Haiti" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 97, "HM", "Heard Island and McDonald Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 98, "VA", "Holy See (Vatican City State)" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 99, "HN", "Honduras" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 100, "HK", "Hong Kong" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 101, "HU", "Hungary" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 102, "IS", "Iceland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 103, "IN", "India" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 104, "ID", "Indonesia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 105, "IR", "Iran, Islamic Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 106, "IQ", "Iraq" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 107, "IE", "Ireland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 108, "IM", "Isle of Man" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 109, "IL", "Israel" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 110, "IT", "Italy" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 111, "JM", "Jamaica" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 112, "JP", "Japan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 113, "JE", "Jersey" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 114, "JO", "Jordan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 115, "KZ", "Kazakhstan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 116, "KE", "Kenya" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 117, "KI", "Kiribati" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 118, "KP", "Korea, Democratic People's Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 119, "KR", "Korea, Republic of" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 120, "KW", "Kuwait" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 121, "KG", "Kyrgyzstan" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 122, "LA", "Lao People's Democratic Republic" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 95, "GY", "Guyana" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 94, "GW", "Guinea-Bissau" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 93, "GN", "Guinea" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 92, "GG", "Guernsey" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 64, "DO", "Dominican Republic" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 65, "EC", "Ecuador" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 66, "EG", "Egypt" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 67, "SV", "El Salvador" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 68, "GQ", "Equatorial Guinea" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 69, "ER", "Eritrea" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 70, "EE", "Estonia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 71, "ET", "Ethiopia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 72, "FK", "Falkland Islands (Malvinas)" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 73, "FO", "Faroe Islands" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 74, "FJ", "Fiji" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 75, "FI", "Finland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 76, "FR", "France" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 124, "LB", "Lebanon" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 77, "GF", "French Guiana" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 79, "TF", "French Southern Territories" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 80, "GA", "Gabon" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 81, "GM", "Gambia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 82, "GE", "Georgia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 83, "DE", "Germany" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 84, "GH", "Ghana" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 85, "GI", "Gibraltar" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 86, "GR", "Greece" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 87, "GL", "Greenland" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 88, "GD", "Grenada" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 89, "GP", "Guadeloupe" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 90, "GU", "Guam" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 91, "GT", "Guatemala" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 78, "PF", "French Polynesia" });

            migrationBuilder.InsertData(
                table: "sys_Countries",
                columns: new[] { "Id", "Code", "DefaultName" },
                values: new object[] { 249, "ZW", "Zimbabwe" });

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
