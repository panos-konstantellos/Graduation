namespace Graduation.Core.Data
{
    public sealed record DisabilityAidLocalization
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int DisabilityAidId { get; set; }

        public DisabilityAid DisabilityAid { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}