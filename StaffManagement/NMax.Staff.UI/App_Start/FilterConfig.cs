using NMax.Staff.UI.Filters;
using System.Web;
using System.Web.Mvc;

namespace NMax.Staff.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new NMaxAuthorizeAttribute());
        }
    }
}