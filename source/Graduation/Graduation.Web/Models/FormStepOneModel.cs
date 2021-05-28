using System.Collections.Generic;

using Graduation.Core;

namespace Graduation.Web.Models
{
    public record DepartmentModel
    {
        public string Name { get; init; }
    }
    
    public record FormStepOneModel
    {
        public IEnumerable<PostalCode> PostalCodes { get; init; }

        public  IEnumerable<DepartmentModel> Departments { get; set; }
        
        public FormStepOneModel()
        {
            this.PostalCodes = new List<PostalCode>();
        }
    }
}