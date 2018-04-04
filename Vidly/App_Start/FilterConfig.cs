using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //redirect to error page when exception happen
            filters.Add(new HandleErrorAttribute());
            //register global filter
            filters.Add(new AuthorizeAttribute());
        }
    }
}
