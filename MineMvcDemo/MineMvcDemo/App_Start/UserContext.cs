using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MineMvcDemo.App_Start
{
    public class UserContext
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 登录id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string AccountName { get; set; }
    }
}