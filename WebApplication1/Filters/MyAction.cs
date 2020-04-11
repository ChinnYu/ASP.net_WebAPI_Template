using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class MyAction:ActionFilterAttribute
    {
        //表示行為前，需要處理的代碼
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // base.OnActionExecuting(filterContext);
            filterContext.HttpContext.Response.Write("ing<br>");
        }
        //表示行為後，需要處理的代碼
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // base.OnActionExecuted(filterContext);
            filterContext.HttpContext.Response.Write("ed<br>");
        }
    }
}