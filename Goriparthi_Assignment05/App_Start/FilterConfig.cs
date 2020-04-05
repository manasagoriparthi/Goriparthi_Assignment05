using System.Web;
using System.Web.Mvc;

namespace Goriparthi_Assignment05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
