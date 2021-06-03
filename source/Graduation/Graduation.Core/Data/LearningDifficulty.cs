using System.Collections.Generic;

namespace Graduation.Core.Data
{
    public sealed record LearningDifficulty
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string DefaultTitle { get; set; }
        
        public string DefaultDescription { get; set; }
        
        public ICollection<LearningDifficultyLocalization> LearningDifficultyLocalizations { get; set; }

        public LearningDifficulty()
        {
            this.LearningDifficultyLocalizations = new List<LearningDifficultyLocalization>();
        }
    }
}