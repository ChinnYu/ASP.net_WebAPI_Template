using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BaseController : Controller
    {
        //過濾器的第二種實現方式:重寫控制器的方法，這樣，會應用於所有的行為
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            // base.OnAuthorization(filterContext);
            filterContext.HttpContext.Response.Write("456");
        }
    }
}