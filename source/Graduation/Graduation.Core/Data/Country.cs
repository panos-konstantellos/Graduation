using System.Collections.Generic;

namespace Graduation.Core
{
    public record Country
    {
        public int Id { get; set; }

        public string DefaultName { get; set; }

        public string Code { get; set; }
        
        public ICollection<CountryLocalization> CountryLocalizations { get; set; }

        public Country()
        {
            this.CountryLocalizations = new List<CountryLocalization>();
        }
    }
}