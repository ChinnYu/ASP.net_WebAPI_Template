using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class MyAuthorization:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //如果保留如下代碼，則會運行.net framework 定義好的身分驗證，如果希望自定義身分驗證，則刪除如下代碼
            // base.OnAuthorization(filterContext);
            
            //如果希望跳轉到另一個頁面，需要使用Result,而不是使用Response.Redirect(),第二種方案不會讓服務器端停止執行
            // filterContext.Result = new RedirectResult(UrlHelper.GenerateUrl("","Login","UserInfo"));
            
            //獲取路由數據:當前上下文匹配到路由規則後，得到一個對象
            // filterContext.RouteData
            
            //獲取上下文
            filterContext.HttpContext.Response.Write("123");
        }
    }
}