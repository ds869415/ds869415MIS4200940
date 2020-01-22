using System.Web;
using System.Web.Mvc;

namespace ds869415MIS4200940
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
