using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class MyException:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //如下代碼不可以被刪除，所以捕獲不到異常
            base.OnException(filterContext);
            //紀錄日誌
            
            //頁面跳轉
            filterContext.Result = new RedirectResult("/Error/404.html");
        }
    }
}