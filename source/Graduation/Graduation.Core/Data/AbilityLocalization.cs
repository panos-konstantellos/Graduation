namespace Graduation.Core
{
    public sealed record AbilityLocalization
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int AbilityId { get; set; }

        public Ability Ability { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}