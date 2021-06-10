namespace Graduation.Core
{
    public record CountryLocalization
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}