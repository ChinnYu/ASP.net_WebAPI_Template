using System;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    [MyAuthorization]//當前控制器下的所有行為，都被應用了這個過濾器
    public class FtestController : BaseController
    {
        // GET
        //當前行為在執行前，會執行身分驗證
        // [MyAuthorization]
        [MyAction]
        [MyResult]
        public ActionResult Index()
        {
            Response.Write("3333");
            return View();
        }
        
        public ActionResult Show()
        {
            throw new Exception("");
            return View();
        }
        
        // //過濾器的第二種實現方式:重寫控制器的方法，這樣，會應用於所有的行為
        // protected override void OnAuthorization(AuthorizationContext filterContext)
        // {
        //     // base.OnAuthorization(filterContext);
        //     filterContext.HttpContext.Response.Write("456");
        // }
    }
}