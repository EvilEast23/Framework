using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NMax.Staff.UI.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (System.Threading.Thread.CurrentPrincipal.IsInRole("admin"))
            //{

            //}
            base.OnActionExecuting(filterContext);
        }
    }
}
