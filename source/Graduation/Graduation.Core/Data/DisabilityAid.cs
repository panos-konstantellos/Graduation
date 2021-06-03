using System.Collections.Generic;

namespace Graduation.Core.Data
{
    public enum DisabilityAidType
    {
        Physical = 0,
        Digital = 1
    }

    public sealed record DisabilityAid
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public DisabilityAidType DisabilityAidType { get; set; }
        
        public string DefaultTitle { get; set; }
        
        public string DefaultDescription { get; set; }
        
        public ICollection<DisabilityAidLocalization> DisabilityAidLocalizations { get; set; }

        public DisabilityAid()
        {
            this.DisabilityAidLocalizations = new List<DisabilityAidLocalization>();
        }
    }
}