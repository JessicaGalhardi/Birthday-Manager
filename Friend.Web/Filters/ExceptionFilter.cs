using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Friend.Web.Filters
{
    public class ExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new ViewResult { ViewName = "unknownError" };

            base.OnException(context);
        }

       
    }
}
