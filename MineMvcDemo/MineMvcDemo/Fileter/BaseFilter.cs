using MineMvcDemo.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MineMvcDemo.Fileter
{
    public class BaseFilter : ActionFilterAttribute
    {
        #region 登录校验
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpCookie cookie = filterContext.HttpContext.Request.Cookies[SiteConfig.CookieName];
            bool isAuthenticated = filterContext.HttpContext.Request.IsAuthenticated;
            if (cookie == null || !isAuthenticated)
            {
                filterContext.Result = new RedirectResult(SiteConfig.LoginUrl);
                return;
            }

            try
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);
                if (ticket == null || ticket.UserData == null)
                {
                    filterContext.Result = new RedirectResult(SiteConfig.LoginUrl);
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            base.OnActionExecuting(filterContext);
        }
        #endregion
    }
}