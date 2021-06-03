using System.Collections.Generic;

namespace Graduation.Core
{
    public sealed record QualificationType
    {
        public int Id { get; set; }
        
        public string DefaultName { get; set; }
        
        public ICollection<QualificationTypeLocalization> QualificationTypeLocalizations { get; set; }

        public QualificationType()
        {
            this.QualificationTypeLocalizations = new List<QualificationTypeLocalization>();
        }
    }
}