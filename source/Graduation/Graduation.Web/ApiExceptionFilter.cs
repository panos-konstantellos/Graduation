using System.Net;

using Graduation.Web.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Graduation.Web
{
    public class ApiExceptionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // No need to run code before method execution.
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Controller is not ApiController)
            {
                return;
            }
            
            if (context.Exception == null)
            {
                return;
            }

            
            context.Result = new ObjectResult(context.Exception.ToHttpException())
            {
                StatusCode = (int) HttpStatusCode.InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}