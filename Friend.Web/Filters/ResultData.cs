using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Friend.Web.Filters
{
    public class ResultData
    {
        public DateTime CurrentTimeStamp { get; set; }
        public object? Value { get; set; }
        public ResultData(object _Value)
        {
            CurrentTimeStamp = DateTime.Now;
            Value = _Value;
        }
    }
    public class ResultFilter : ResultFilterAttribute
    {

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            var data = context.Result as ObjectResult;
            data.Value = new ResultData(data.Value);

            base.OnResultExecuted(context);
        }

    }
}
