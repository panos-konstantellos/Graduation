using System.Collections.Generic;

namespace Graduation.Core
{
    public sealed record OperationalDifficulty
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string DefaultTitle { get; set; }
        
        public string DefaultDescription { get; set; }
        
        public ICollection<OperationalDifficultyLocalization> OperationalDifficultyLocalizations { get; set; }

        public OperationalDifficulty()
        {
            this.OperationalDifficultyLocalizations = new List<OperationalDifficultyLocalization>();
        }
    }
}