namespace Graduation.Web
{
    public class ExceptionModel
    {
        public string Message { get; set; }

        public ExceptionModel? InnerException { get; set; }

        public string StackTrace { get; set; }
    }
}