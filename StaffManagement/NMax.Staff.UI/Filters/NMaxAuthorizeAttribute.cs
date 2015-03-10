using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NMax.Staff.Security;

namespace NMax.Staff.UI.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class NMaxAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                string securityId = null;
                var controller = filterContext.ActionDescriptor.ControllerDescriptor;
                var action = filterContext.ActionDescriptor;

                var attrs = action.GetCustomAttributes(typeof(NMaxSecurity), false);
                if (attrs.Length == 1)
                {
                    securityId = ((NMaxSecurity)attrs[0]).SecurityId;
                }
                else
                {
                    attrs = controller.GetCustomAttributes(typeof(NMaxSecurity), false);
                    if (attrs.Length == 1)
                    {
                        securityId = ((NMaxSecurity)attrs[0]).SecurityId;
                    }
                }

                //check the permission
                if (!string.IsNullOrEmpty(securityId))
                {
                    if (!System.Threading.Thread.CurrentPrincipal.IsInRole(securityId))
                    {
                        //redirect the error page
                    }
                }
            }
            base.OnAuthorization(filterContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }
    }
}