using System.Collections.Generic;

namespace Graduation.Web
{
    public class ValidationExceptionModel : ExceptionModel
    {
        public ICollection<ValidationErrorModel> ValidationErrors { get; set; }

        public ValidationExceptionModel()
        {
            this.ValidationErrors = new List<ValidationErrorModel>();
        }
    }
}