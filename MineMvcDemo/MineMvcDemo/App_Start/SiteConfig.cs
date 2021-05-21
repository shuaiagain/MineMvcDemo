using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MineMvcDemo.App_Start
{
    public class SiteConfig
    {
        /// <summary>
        /// cookie 名称
        /// </summary>
        public const string CookieName = "Test";

        /// <summary>
        /// 登录url
        /// </summary>
        public const string LoginUrl = "~/account/login";
    }
}