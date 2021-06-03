namespace Graduation.Core.Data
{
    public sealed record LearningDifficultyLocalization
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int LearningDifficultyId { get; set; }

        public LearningDifficulty LearningDifficulty { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}