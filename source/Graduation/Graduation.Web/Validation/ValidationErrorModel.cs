namespace Graduation.Web
{
    public class ValidationErrorModel
    {
        public string PropertyName { get; set; }

        public string Message { get; set; }

        public object AttemptedValue { get; set; }

        public string ErrorCode { get; set; }
    }
}