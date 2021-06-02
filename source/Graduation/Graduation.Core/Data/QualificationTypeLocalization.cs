namespace Graduation.Core
{
    public sealed record QualificationTypeLocalization
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int LanguageId { get; set; }
        
        public Language Language { get; set; }
        
        public int QualificationTypeId { get; set; }
        
        public QualificationType QualificationType { get; set; }
    }
}