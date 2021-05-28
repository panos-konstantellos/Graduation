using Microsoft.EntityFrameworkCore;

namespace Graduation.Core
{
    public sealed class EducationContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentLocalization> DepartmentLocalizations { get; set; }
        
        public EducationContext(DbContextOptions<EducationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Language>()
                .ToTable("sys_Languages")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Language>()
                .HasIndex(x => x.Code)
                .IsUnique();

            modelBuilder.Entity<Language>()
                .HasData(
                    new Language { Id = 1, Name = "Greek", Code = "el" },
                    new Language { Id = 2, Name = "Abkhazian", Code = "ab" },
                    new Language { Id = 3, Name = "Afar", Code = "aa" },
                    new Language { Id = 4, Name = "Afrikaans", Code = "af" },
                    new Language { Id = 5, Name = "Akan", Code = "ak" },
                    new Language { Id = 6, Name = "Albanian", Code = "sq" },
                    new Language { Id = 7, Name = "Amharic", Code = "am" },
                    new Language { Id = 8, Name = "Arabic", Code = "ar" },
                    new Language { Id = 9, Name = "Aragonese", Code = "an" },
                    new Language { Id = 10, Name = "Armenian", Code = "hy" },
                    new Language { Id = 11, Name = "Assamese", Code = "as" },
                    new Language { Id = 12, Name = "Avaric", Code = "av" },
                    new Language { Id = 13, Name = "Avestan", Code = "ae" },
                    new Language { Id = 14, Name = "Aymara", Code = "ay" },
                    new Language { Id = 15, Name = "Azerbaijani", Code = "az" },
                    new Language { Id = 16, Name = "Bambara", Code = "bm" },
                    new Language { Id = 17, Name = "Bashkir", Code = "ba" },
                    new Language { Id = 18, Name = "Basque", Code = "eu" },
                    new Language { Id = 19, Name = "Belarusian", Code = "be" },
                    new Language { Id = 20, Name = "Bengali", Code = "bn" },
                    new Language { Id = 21, Name = "Bihari languages", Code = "bh" },
                    new Language { Id = 22, Name = "Bislama", Code = "bi" },
                    new Language { Id = 24, Name = "Bosnian", Code = "bs" },
                    new Language { Id = 25, Name = "Breton", Code = "br" },
                    new Language { Id = 26, Name = "Bulgarian", Code = "bg" },
                    new Language { Id = 27, Name = "Burmese", Code = "my" },
                    new Language { Id = 29, Name = "Catalan", Code = "ca" },
                    new Language { Id = 30, Name = "Central Khmer", Code = "km" },
                    new Language { Id = 31, Name = "Chamorro", Code = "ch" },
                    new Language { Id = 32, Name = "Chechen", Code = "ce" },
                    new Language { Id = 33, Name = "Chewa", Code = "ny" },
                    new Language { Id = 35, Name = "Chinese", Code = "zh" },
                    new Language { Id = 37, Name = "Church Slavic", Code = "cu" },
                    new Language { Id = 39, Name = "Chuvash", Code = "cv" },
                    new Language { Id = 40, Name = "Cornish", Code = "kw" },
                    new Language { Id = 41, Name = "Corsican", Code = "co" },
                    new Language { Id = 42, Name = "Cree", Code = "cr" },
                    new Language { Id = 43, Name = "Croatian", Code = "hr" },
                    new Language { Id = 44, Name = "Czech", Code = "cs" },
                    new Language { Id = 45, Name = "Danish", Code = "da" },
                    new Language { Id = 48, Name = "Dutch", Code = "nl" },
                    new Language { Id = 49, Name = "Dzongkha", Code = "dz" },
                    new Language { Id = 50, Name = "English", Code = "en" },
                    new Language { Id = 51, Name = "Esperanto", Code = "eo" },
                    new Language { Id = 52, Name = "Estonian", Code = "et" },
                    new Language { Id = 53, Name = "Ewe", Code = "ee" },
                    new Language { Id = 54, Name = "Faroese", Code = "fo" },
                    new Language { Id = 55, Name = "Fijian", Code = "fj" },
                    new Language { Id = 56, Name = "Finnish", Code = "fi" },
                    new Language { Id = 58, Name = "French", Code = "fr" },
                    new Language { Id = 59, Name = "Fulah", Code = "ff" },
                    new Language { Id = 60, Name = "Gaelic", Code = "gd" },
                    new Language { Id = 61, Name = "Galician", Code = "gl" },
                    new Language { Id = 62, Name = "Ganda", Code = "lg" },
                    new Language { Id = 63, Name = "Georgian", Code = "ka" },
                    new Language { Id = 64, Name = "German", Code = "de" },
                    new Language { Id = 66, Name = "Greenlandic", Code = "kl" },
                    new Language { Id = 67, Name = "Guarani", Code = "gn" },
                    new Language { Id = 68, Name = "Gujarati", Code = "gu" },
                    new Language { Id = 69, Name = "Haitian", Code = "ht" },
                    new Language { Id = 71, Name = "Hausa", Code = "ha" },
                    new Language { Id = 72, Name = "Hebrew", Code = "he" },
                    new Language { Id = 73, Name = "Herero", Code = "hz" },
                    new Language { Id = 74, Name = "Hindi", Code = "hi" },
                    new Language { Id = 75, Name = "Hiri Motu", Code = "ho" },
                    new Language { Id = 76, Name = "Hungarian", Code = "hu" },
                    new Language { Id = 77, Name = "Icelandic", Code = "is" },
                    new Language { Id = 78, Name = "Ido", Code = "io" },
                    new Language { Id = 79, Name = "Igbo", Code = "ig" },
                    new Language { Id = 80, Name = "Indonesian", Code = "id" },
                    new Language { Id = 81, Name = "Interlingua (International Auxiliary Language Association)", Code = "ia" },
                    new Language { Id = 82, Name = "Interlingue", Code = "ie" },
                    new Language { Id = 83, Name = "Inuktitut", Code = "iu" },
                    new Language { Id = 84, Name = "Inupiaq", Code = "ik" },
                    new Language { Id = 85, Name = "Irish", Code = "ga" },
                    new Language { Id = 86, Name = "Italian", Code = "it" },
                    new Language { Id = 87, Name = "Japanese", Code = "ja" },
                    new Language { Id = 88, Name = "Javanese", Code = "jv" },
                    new Language { Id = 90, Name = "Kannada", Code = "kn" },
                    new Language { Id = 91, Name = "Kanuri", Code = "kr" },
                    new Language { Id = 92, Name = "Kashmiri", Code = "ks" },
                    new Language { Id = 93, Name = "Kazakh", Code = "kk" },
                    new Language { Id = 94, Name = "Kikuyu", Code = "ki" },
                    new Language { Id = 95, Name = "Kinyarwanda", Code = "rw" },
                    new Language { Id = 97, Name = "Komi", Code = "kv" },
                    new Language { Id = 98, Name = "Kongo", Code = "kg" },
                    new Language { Id = 99, Name = "Korean", Code = "ko" },
                    new Language { Id = 101, Name = "Kurdish", Code = "ku" },
                    new Language { Id = 102, Name = "Kwanyama", Code = "kj" },
                    new Language { Id = 103, Name = "Kyrgyz", Code = "ky" },
                    new Language { Id = 104, Name = "Lao", Code = "lo" },
                    new Language { Id = 105, Name = "Latin", Code = "la" },
                    new Language { Id = 106, Name = "Latvian", Code = "lv" },
                    new Language { Id = 108, Name = "Limburgan", Code = "li" },
                    new Language { Id = 111, Name = "Lingala", Code = "ln" },
                    new Language { Id = 112, Name = "Lithuanian", Code = "lt" },
                    new Language { Id = 113, Name = "Luba-Katanga", Code = "lu" },
                    new Language { Id = 114, Name = "Luxembourgish", Code = "lb" },
                    new Language { Id = 115, Name = "Macedonian", Code = "mk" },
                    new Language { Id = 116, Name = "Malagasy", Code = "mg" },
                    new Language { Id = 117, Name = "Malay", Code = "ms" },
                    new Language { Id = 118, Name = "Malayalam", Code = "ml" },
                    new Language { Id = 119, Name = "Maldivian", Code = "dv" },
                    new Language { Id = 120, Name = "Maltese", Code = "mt" },
                    new Language { Id = 121, Name = "Manx", Code = "gv" },
                    new Language { Id = 122, Name = "Maori", Code = "mi" },
                    new Language { Id = 123, Name = "Marathi", Code = "mr" },
                    new Language { Id = 124, Name = "Marshallese", Code = "mh" },
                    new Language { Id = 127, Name = "Mongolian", Code = "mn" },
                    new Language { Id = 128, Name = "Nauru", Code = "na" },
                    new Language { Id = 130, Name = "Navajo", Code = "nv" },
                    new Language { Id = 133, Name = "Ndonga", Code = "ng" },
                    new Language { Id = 134, Name = "Nepali", Code = "ne" },
                    new Language { Id = 135, Name = "North Ndebele", Code = "nd" },
                    new Language { Id = 136, Name = "Northern Sami", Code = "se" },
                    new Language { Id = 137, Name = "Norwegian", Code = "no" },
                    new Language { Id = 138, Name = "Norwegian Bokmål", Code = "nb" },
                    new Language { Id = 139, Name = "Norwegian Nynorsk", Code = "nn" },
                    new Language { Id = 140, Name = "Nuosu", Code = "ii" },
                    new Language { Id = 144, Name = "Occitan (post 1500)", Code = "oc" },
                    new Language { Id = 145, Name = "Ojibwa", Code = "oj" },
                    new Language { Id = 149, Name = "Oriya", Code = "or" },
                    new Language { Id = 150, Name = "Oromo", Code = "om" },
                    new Language { Id = 151, Name = "Ossetian", Code = "os" },
                    new Language { Id = 153, Name = "Pali", Code = "pi" },
                    new Language { Id = 155, Name = "Pashto", Code = "ps" },
                    new Language { Id = 156, Name = "Persian", Code = "fa" },
                    new Language { Id = 157, Name = "Polish", Code = "pl" },
                    new Language { Id = 158, Name = "Portuguese", Code = "pt" },
                    new Language { Id = 159, Name = "Punjabi", Code = "pa" },
                    new Language { Id = 161, Name = "Quechua", Code = "qu" },
                    new Language { Id = 162, Name = "Romanian", Code = "ro" },
                    new Language { Id = 163, Name = "Romansh", Code = "rm" },
                    new Language { Id = 164, Name = "Rundi", Code = "rn" },
                    new Language { Id = 165, Name = "Russian", Code = "ru" },
                    new Language { Id = 166, Name = "Samoan", Code = "sm" },
                    new Language { Id = 167, Name = "Sango", Code = "sg" },
                    new Language { Id = 168, Name = "Sanskrit", Code = "sa" },
                    new Language { Id = 169, Name = "Sardinian", Code = "sc" },
                    new Language { Id = 171, Name = "Serbian", Code = "sr" },
                    new Language { Id = 172, Name = "Shona", Code = "sn" },
                    new Language { Id = 174, Name = "Sindhi", Code = "sd" },
                    new Language { Id = 175, Name = "Sinhala", Code = "si" },
                    new Language { Id = 177, Name = "Slovak", Code = "sk" },
                    new Language { Id = 178, Name = "Slovenian", Code = "sl" },
                    new Language { Id = 179, Name = "Somali", Code = "so" },
                    new Language { Id = 180, Name = "Sotho, Southern", Code = "st" },
                    new Language { Id = 181, Name = "South Ndebele", Code = "nr" },
                    new Language { Id = 182, Name = "Spanish", Code = "es" },
                    new Language { Id = 183, Name = "Sundanese", Code = "su" },
                    new Language { Id = 184, Name = "Swahili", Code = "sw" },
                    new Language { Id = 185, Name = "Swati", Code = "ss" },
                    new Language { Id = 186, Name = "Swedish", Code = "sv" },
                    new Language { Id = 187, Name = "Tagalog", Code = "tl" },
                    new Language { Id = 188, Name = "Tahitian", Code = "ty" },
                    new Language { Id = 189, Name = "Tajik", Code = "tg" },
                    new Language { Id = 190, Name = "Tamil", Code = "ta" },
                    new Language { Id = 191, Name = "Tatar", Code = "tt" },
                    new Language { Id = 192, Name = "Telugu", Code = "te" },
                    new Language { Id = 193, Name = "Thai", Code = "th" },
                    new Language { Id = 194, Name = "Tibetan", Code = "bo" },
                    new Language { Id = 195, Name = "Tigrinya", Code = "ti" },
                    new Language { Id = 196, Name = "Tonga (Tonga Islands)", Code = "to" },
                    new Language { Id = 197, Name = "Tsonga", Code = "ts" },
                    new Language { Id = 198, Name = "Tswana", Code = "tn" },
                    new Language { Id = 199, Name = "Turkish", Code = "tr" },
                    new Language { Id = 200, Name = "Turkmen", Code = "tk" },
                    new Language { Id = 201, Name = "Twi", Code = "tw" },
                    new Language { Id = 203, Name = "Ukrainian", Code = "uk" },
                    new Language { Id = 204, Name = "Urdu", Code = "ur" },
                    new Language { Id = 205, Name = "Uyghur", Code = "ug" },
                    new Language { Id = 206, Name = "Uzbek", Code = "uz" },
                    new Language { Id = 208, Name = "Venda", Code = "ve" },
                    new Language { Id = 209, Name = "Vietnamese", Code = "vi" },
                    new Language { Id = 210, Name = "Volapük", Code = "vo" },
                    new Language { Id = 211, Name = "Walloon", Code = "wa" },
                    new Language { Id = 212, Name = "Welsh", Code = "cy" },
                    new Language { Id = 213, Name = "Western Frisian", Code = "fy" },
                    new Language { Id = 214, Name = "Wolof", Code = "wo" },
                    new Language { Id = 215, Name = "Xhosa", Code = "xh" },
                    new Language { Id = 216, Name = "Yiddish", Code = "yi" },
                    new Language { Id = 217, Name = "Yoruba", Code = "yo" },
                    new Language { Id = 218, Name = "Zhuang", Code = "za" },
                    new Language { Id = 219, Name = "Zulu", Code = "zu" }
                );
            
            modelBuilder.Entity<Department>()
                .ToTable("edu_Departments")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Department>()
                .HasIndex(x => x.Code)
                .IsUnique();
            
            modelBuilder.Entity<Department>()
                .HasData(
                    new Department { Id = 1, Code = "ice" },
                    new Department { Id = 2, Code = "eee" },
                    new Department { Id = 3, Code = "pch" },
                    new Department { Id = 4, Code = "php" },
                    new Department { Id = 5, Code = "ecec" },
                    new Department { Id = 6, Code = "alis" },
                    new Department { Id = 7, Code = "ba" },
                    new Department { Id = 8, Code = "tourism" },
                    new Department { Id = 9, Code = "sw" },
                    new Department { Id = 10, Code = "accfin" },
                    new Department { Id = 11, Code = "fst" },
                    new Department { Id = 12, Code = "wvbs" },
                    new Department { Id = 13, Code = "bisc" },
                    new Department { Id = 14, Code = "ot" },
                    new Department { Id = 15, Code = "midw" },
                    new Department { Id = 16, Code = "nurs" },
                    new Department { Id = 17, Code = "phys" },
                    new Department { Id = 18, Code = "gd" },
                    new Department { Id = 19, Code = "ia" },
                    new Department { Id = 20, Code = "cons" },
                    new Department { Id = 21, Code = "phaa" },
                    new Department { Id = 22, Code = "bme" },
                    new Department { Id = 23, Code = "idpe" },
                    new Department { Id = 24, Code = "geo" },
                    new Department { Id = 25, Code = "mech" },
                    new Department { Id = 26, Code = "na" },
                    new Department { Id = 27, Code = "civ" }
                );
            
            modelBuilder.Entity<DepartmentLocalization>()
                .ToTable("edu_DepartmentLocalizations")
                .HasKey(x => x.Id);
            
            modelBuilder.Entity<DepartmentLocalization>()
                .HasIndex(x => new {x.DepartmentId, x.LanguageId})
                .IsUnique();
            
            modelBuilder.Entity<DepartmentLocalization>()
                .HasData(
                    new DepartmentLocalization { Id = 1, DepartmentId = 1, LanguageId = 1, Name = "τμήμα μηχανικών πληροφορικής και υπολογιστών" },
                    new DepartmentLocalization { Id = 2, DepartmentId = 2, LanguageId = 1, Name = "τμήμα ηλεκτρολόγων και ηλεκτρονικών μηχανικών" },
                    new DepartmentLocalization { Id = 3, DepartmentId = 3, LanguageId = 1, Name = "τμήμα δημόσιας και κοινοτικής υγείας" },
                    new DepartmentLocalization { Id = 4, DepartmentId = 4, LanguageId = 1, Name = "τμήμα πολιτικών δημόσιας υγείας" },
                    new DepartmentLocalization { Id = 5, DepartmentId = 5, LanguageId = 1, Name = "τμήμα αγωγής και φροντιδας στην πρώιμη παιδική ηλικία" },
                    new DepartmentLocalization { Id = 6, DepartmentId = 6, LanguageId = 1, Name = "τμήμα αρχειονομίας, βιβλιοθηκονομίας και συστημάτων πληροφόρησης" },
                    new DepartmentLocalization { Id = 7, DepartmentId = 7, LanguageId = 1, Name = "τμήμα διοίκησης επιχειρήσεων" },
                    new DepartmentLocalization { Id = 8, DepartmentId = 8, LanguageId = 1, Name = "τμήμα διοίκησης τουρισμού" },
                    new DepartmentLocalization { Id = 9, DepartmentId = 9, LanguageId = 1, Name = "τμήμα κοινωνικής εργασίας" },
                    new DepartmentLocalization { Id = 10, DepartmentId = 10, LanguageId = 1, Name = "τμήμα λογιστικής και χρηματοοικονομικής" },
                    new DepartmentLocalization { Id = 11, DepartmentId = 11, LanguageId = 1, Name = "τμήμα επιστήμης και τεχνολογίας τροφίμων" },
                    new DepartmentLocalization { Id = 12, DepartmentId = 12, LanguageId = 1, Name = "τμήμα επιστημών οίνου, αμπέλου και ποτών" },
                    new DepartmentLocalization { Id = 13, DepartmentId = 13, LanguageId = 1, Name = "τμήμα βιοϊατρικών επιστημών" },
                    new DepartmentLocalization { Id = 14, DepartmentId = 14, LanguageId = 1, Name = "τμήμα εργοθεραπείας" },
                    new DepartmentLocalization { Id = 15, DepartmentId = 15, LanguageId = 1, Name = "τμήμα μαιευτικής" },
                    new DepartmentLocalization { Id = 16, DepartmentId = 16, LanguageId = 1, Name = "τμήμα νοσηλευτικής" },
                    new DepartmentLocalization { Id = 17, DepartmentId = 17, LanguageId = 1, Name = "τμήμα φυσικοθεραπείας" },
                    new DepartmentLocalization { Id = 18, DepartmentId = 18, LanguageId = 1, Name = "τμήμα γραφιστικής και οπτικής επικοινωνίας" },
                    new DepartmentLocalization { Id = 19, DepartmentId = 19, LanguageId = 1, Name = "τμήμα εσωτερικής αρχιτεκτονικής" },
                    new DepartmentLocalization { Id = 20, DepartmentId = 20, LanguageId = 1, Name = "τμήμα συντήρησης αρχαιοτήτων και έργων τέχνης" },
                    new DepartmentLocalization { Id = 21, DepartmentId = 21, LanguageId = 1, Name = "τμήμα φωτογραφίας και οπτικοακουστικών τεχνών" },
                    new DepartmentLocalization { Id = 22, DepartmentId = 22, LanguageId = 1, Name = "τμήμα μηχανικών βιοϊατρικής" },
                    new DepartmentLocalization { Id = 23, DepartmentId = 23, LanguageId = 1, Name = "τμήμα μηχανικών βιομηχανικής σχεδίασης και παραγωγής" },
                    new DepartmentLocalization { Id = 24, DepartmentId = 24, LanguageId = 1, Name = "τμήμα μηχανικών τοπογραφίας και γεωπληροφορικής" },
                    new DepartmentLocalization { Id = 25, DepartmentId = 25, LanguageId = 1, Name = "τμήμα μηχανολόγων μηχανικών" },
                    new DepartmentLocalization { Id = 26, DepartmentId = 26, LanguageId = 1, Name = "τμήμα ναυπηγών μηχανικών" },
                    new DepartmentLocalization { Id = 27, DepartmentId = 27, LanguageId = 1, Name = "τμήμα πολιτικών μηχανικών" }
                );
        }
    }
}