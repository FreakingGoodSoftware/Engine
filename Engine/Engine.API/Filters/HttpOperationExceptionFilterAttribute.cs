using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Engine.API.Filters
{
    public class HttpOperationExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is Microsoft.Rest.HttpOperationException)
            {
                var ex = (Microsoft.Rest.HttpOperationException)context.Exception;
                context.Response = ex.Response;
            }
        }
    }
}