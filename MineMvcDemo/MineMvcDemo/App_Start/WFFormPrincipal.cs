using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace MineMvcDemo.App_Start
{
    public class WFFormPrincipal : IPrincipal
    {
        public IIdentity Identity { get; set; }

        public FormsAuthentication UserData { get; set; }

        public WFFormPrincipal(FormsAuthenticationTicket ticket, WFFormsAuthenticatoin userData)
        {
            if (ticket == null) throw new ArgumentNullException("ticket");

            if (userData == null) throw new ArgumentNullException("userData");

            Identity = new FormsIdentity(ticket);
        }

        public bool IsInRole(string role) { return false; }
    }

    public class WFFormsAuthenticatoin
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public int AccountId { get; set; }

        public string AccountName { get; set; }
    }
}