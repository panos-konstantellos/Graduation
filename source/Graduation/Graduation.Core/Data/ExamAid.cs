using System.Collections.Generic;

namespace Graduation.Core.Data
{
    public sealed record ExamAid
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string DefaultTitle { get; set; }
        
        public string DefaultDescription { get; set; }
        
        public ICollection<ExamAidLocalization> ExamAidLocalizations { get; set; }

        public ExamAid()
        {
            this.ExamAidLocalizations = new List<ExamAidLocalization>();
        }
    }
    
    public sealed record ExamAidLocalization
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int ExamAidid { get; set; }

        public ExamAid ExamAid { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}