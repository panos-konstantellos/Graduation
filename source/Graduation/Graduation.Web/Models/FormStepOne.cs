using System.Collections.Generic;

using Graduation.Core;

namespace Graduation.Web.Models
{
    public record FormStepOne
    {
        public IEnumerable<PostalCode> PostalCodes { get; init; }

        public FormStepOne()
        {
            this.PostalCodes = new List<PostalCode>();
        }
    }
}