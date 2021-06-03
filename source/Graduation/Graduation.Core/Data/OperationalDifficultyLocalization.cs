namespace Graduation.Core
{
    public sealed record OperationalDifficultyLocalization
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int OperationalDifficultyId { get; set; }

        public OperationalDifficulty OperationalDifficulty { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}