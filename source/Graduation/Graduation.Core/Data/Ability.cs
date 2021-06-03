using System.Collections.Generic;

namespace Graduation.Core
{
    public sealed record Ability
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string DefaultTitle { get; set; }
        
        public string DefaultDescription { get; set; }
        
        public ICollection<AbilityLocalization> AbilityLocalizations { get; set; }

        public Ability()
        {
            this.AbilityLocalizations = new List<AbilityLocalization>();
        }
    }
}