using System;
using System.Linq;

namespace Graduation.Web
{
    internal static class HttpExceptionExtensions
    {
        public static ExceptionModel ToHttpException(this Exception e)
        {
            return e switch
            {
                FluentValidation.ValidationException exception => new ValidationExceptionModel
                {
                    Message = e.Message,
                    InnerException = e?.InnerException?.ToHttpException(),
                    StackTrace = e.StackTrace,
                    ValidationErrors = exception.Errors.Select(x => new ValidationErrorModel
                        {
                            Message = x.ErrorMessage,
                            PropertyName = x.PropertyName,
                            AttemptedValue = x.AttemptedValue,
                            ErrorCode = x.ErrorCode
                        })
                        .ToList()
                },
                System.ComponentModel.DataAnnotations.ValidationException exception => new
                    ValidationExceptionModel()
                    {
                        Message = e.Message,
                        InnerException = e?.InnerException?.ToHttpException(),
                        StackTrace = e.StackTrace,
                        ValidationErrors = exception?.ValidationResult?.MemberNames?.Select(x =>
                                new ValidationErrorModel
                                {
                                    Message = (e as System.ComponentModel.DataAnnotations.ValidationException)
                                        ?.ValidationResult?.ErrorMessage ?? String.Empty,
                                    PropertyName = x
                                })
                            ?.ToList()
                    },
                _ => new ExceptionModel
                {
                    Message = e.Message,
                    InnerException = e?.InnerException?.ToHttpException(),
                    StackTrace = e.StackTrace
                }
            };
        }
    }
}