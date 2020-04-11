using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class MyResult:ActionFilterAttribute
    {
        //表示結果執行前，需要處理的代碼
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // base.OnResultExecuting(filterContext);
            filterContext.HttpContext.Response.Write("結果執行前<br>");
        }
        
        //表示結果執行後，需要執行的代碼
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            // base.OnResultExecuted(filterContext);
            filterContext.HttpContext.Response.Write("結果執行後<br>");
        }
    }
}